using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemonWrapper.Lighting;
using NetDaemon.Extensions.Scheduler;
using System.Threading;
using NetDaemon;
using System.Drawing;
using Newtonsoft.Json;
using NetDaemon.HassModel;
using System.Runtime.CompilerServices;

namespace NetDaemonWrapper.Scene
{
    public class Scene
    {
        private static UInt16 scenecount = 0;
        public readonly UInt16 SceneIdentifier;
        public static List<Scene> All = new List<Scene>();
        public readonly string SceneName;
        private SettingsFile Settings;

        public delegate void SceneAction(List<MLight> lights);

        private Timer UpdateTimer;
        private int UpdateTimeMS;

        public readonly SceneAction Action;

        public Scene(string _SceneName, SceneAction _Action)
        {
            Settings = new SettingsFile("Lighting/Scenes/" + _SceneName + ".xml");
            SceneName = "scene." + _SceneName;

            Action = _Action;

            UpdateTimer = new Timer((sender) => InvokeAction());
            UpdateTimer.Change(-1, -1);

            //Register scene with list
            scenecount++;
            SceneIdentifier = scenecount;
            Console.WriteLine("Scene Added: " + SceneName);
            All.Add(this);

            SubscribeScene();
        }

        private void SubscribeScene()
        {
            //Subscribe to this scene service call event
            Context.ha.Events
                .Where(e => e.EventType == "call_service")
                .Where(e => Utils.toDataElement(e.DataElement).domain == "scene")
                .Where(e => Utils.toServiceData(Utils.toDataElement(e.DataElement).service_data).entity_id == SceneName)
            .Subscribe(s => _setScene(this));
        }

        public Scene(string _SceneName, float _UpdateSeconds, SceneAction _Action) : this(_SceneName, _Action)
        {
            UpdateTimeMS = (int)(1000 * float.Parse(Settings.ReadSetDefault("Settings", "UpdateSeconds", _UpdateSeconds.ToString())));
        }

        private static void _setScene(Scene s)
        {
            Console.WriteLine("Scene Set: " + s.SceneName);

            //TODO: These currently pass MLight.All for testing. In the future, find relevant lights and pass only those.
            foreach (MLight l in MLight.All)
            {
                l.Custom.isActive = false;
                l.SceneIdentifier = s.SceneIdentifier;
            }

            if (s.CheckActive())
            {
                s.UpdateTimer.Change(0, s.UpdateTimeMS);
            }
            else
            {
                s.UpdateTimer.Change(-1, -1);
            }
        }

        private bool CheckActive()
        {
            foreach (MLight l in MLight.All)
            {
                if (l.SceneIdentifier == SceneIdentifier)
                {
                    return true;
                }
            }
            return false;
        }

        private void InvokeAction()
        {
            if (CheckActive())
                Action.Invoke(GetActiveLights());
            else
                UpdateTimer.Change(-1, -1);
        }

        private List<MLight> GetActiveLights()
        {
            List<MLight> ActiveLights = new List<MLight>();
            foreach (MLight l in MLight.All)
            {
                if (l.SceneIdentifier == SceneIdentifier)
                {
                    ActiveLights.Add(l);
                }
            }
            return ActiveLights;
        }
    }

    [NetDaemonApp]
    public class SceneInit
    {
        public SceneInit(IHaContext ha)
        {
            RuntimeHelpers.RunClassConstructor(typeof(Scenes).TypeHandle);
        }
    }
}