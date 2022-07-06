using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemonWrapper.Lighting;
using NetDaemon.Extensions.Scheduler;
using NetDaemonWrapper.Events;
using System.Threading;
using NetDaemon;
using System.Drawing;
using Newtonsoft.Json;

namespace NetDaemonWrapper.Scene
{
    public class Scene
    {
        private static UInt16 scenecount = 0;
        public readonly UInt16 SceneIdentifier;
        private static bool isRegistered = false;
        public static List<Scene> All = new List<Scene>();
        public readonly string SceneName;
        private SettingsFile Settings;

        public delegate void SceneAction(List<MLight> lights);

        private Timer UpdateTimer;
        private int UpdateTime;

        public readonly SceneAction Action;

        public Scene(string _SceneName, SceneAction _Action)
        {
            Settings = new SettingsFile("Lighting/Scenes/" + _SceneName + ".xml");
            SceneName = "scene." + _SceneName;
            Settings.ReadSetDefault("General", "Name", SceneName);
            Console.WriteLine("Scene Added: " + SceneName);
            Action = _Action;
            SetSceneEvent();
            scenecount++;
            SceneIdentifier = scenecount;
            All.Add(this);
            UpdateTimer = new Timer((sender) => InvokeAction());
            UpdateTimer.Change(-1, -1);
        }

        public Scene(string _SceneName, int UpdateMilliseconds, SceneAction _Action) : this(_SceneName, _Action)
        {
            UpdateTime = int.Parse(Settings.ReadSetDefault("Settings", "UpdateMilliseconds", UpdateMilliseconds.ToString()));
        }

        private static void SetSceneEvent()
        {
            if (!isRegistered)
            {
                EventManager.Instance.SceneSetEvent += SetScene;
                isRegistered = true;
            }
        }

        public static void SetScene(DataElement d)
        {
            ServiceData? sd = EventManager.toServiceData(d.service_data);

            if (sd?.entity_id != null)
            {
                String name = sd.entity_id;
                bool found = false;
                foreach (Scene s in All)
                {
                    if (s.SceneName == sd.entity_id)
                    {
                        found = true;
                        _setScene(s);
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Scene Not Found: " + sd.entity_id);
                }
            }
        }

        private static void _setScene(Scene s)
        {
            Console.WriteLine("Scene Set: " + s.SceneName);
            ClearCustomLayers();

            //TODO: These currently pass MLight.All for testing. In the future, find relevant lights and pass only those.
            foreach (MLight l in MLight.All)
            {
                l.SceneIdentifier = s.SceneIdentifier;
            }

            if (s.CheckActive())
            {
                s.UpdateTimer.Change(0, s.UpdateTime);
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

        public static void ClearCustomLayers()
        {
            foreach (MLight l in MLight.All)
            {
                l.Custom.isActive = false;
            }
        }
    }
}