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
        private int _sceneidentifier;
        private static bool SceneEventSubscribed = false;

        private static Scene NullScene;

        public int SceneIdentifier
        { get { return _sceneidentifier; } }

        public static List<Scene> All = new List<Scene>();
        private string _scenename;

        public string SceneName
        {
            get { return _scenename; }
        }

        private SettingsFile Settings;

        public delegate void SceneAction(SettingsFile settings, List<MLight> lights);

        private Timer UpdateTimer;
        private int UpdateTimeMS;

        public readonly SceneAction Action;

        public Scene(IHaContext _ha, ILogger _logger, string _SceneName, SceneAction _Action)
        {
            //Check if the scene changer is subscribed. If it isn't, subscribe it.
            if (!SceneEventSubscribed)
            {
                //Build the null scene while we are initializing things
                if (NullScene == null)
                {
                    if (_SceneName != "null")
                    {
                        NullScene = new Scene(_ha, _logger, "null", (a, b) => { });
                    }
                }

                SubscribeSceneChangeEvent();
            }

            Action = _Action;
            _scenename = "scene." + _SceneName;
            Settings = new SettingsFile(PATHS.SCENES + _SceneName + ".xml");
            UpdateTimer = new Timer((sender) => InvokeAction());
            UpdateTimer.Change(-1, -1);

            //Register scene with list
            AddScene();
        }

        /// <summary>
        /// Register scene and add to listeners
        /// </summary>
        private void AddScene()
        {
            bool exists = false;
            for (int i = 0; i < All.Count; i++)
            {
                if (All[i].SceneName == SceneName)
                {
                    exists = true;
                    _sceneidentifier = i;
                    All[i] = this;
                    Console.WriteLine("Scene Replaced At " + _sceneidentifier.ToString() + " : " + SceneName);
                }
            }
            if (!exists)
            {
                All.Add(this);
                _sceneidentifier = All.Count - 1;
                Console.WriteLine("Scene Added At " + _sceneidentifier.ToString() + " : " + SceneName);
            }
        }

        /// <summary>
        /// Add listener for when scene is called.
        /// </summary>
        private void SubscribeSceneChangeEvent()
        {
            //Subscribe the scene change handler to scene.turn_on events
            IObservable<NetDaemon.HassModel.Event> scene_events = Context.ha.Events;
            scene_events = scene_events.Where(e => e.EventType == "call_service");
            scene_events = scene_events.Where(e => Utils.toDataElement(e.DataElement).domain == "scene" && Utils.toDataElement(e.DataElement).service == "turn_on");

            if (scene_events.Subscribe(s => SceneChangeHandler(s)) != null)
                SceneEventSubscribed = true;
        }

        private static void SceneChangeHandler(NetDaemon.HassModel.Event sceneevent)
        {
            /*
             Additional things we could do in here:
            - Pull a list of lights from the scene that was called
            - Pull the states of these lights. That way the scene can start with whatever values exist in the scene.
            - Somehow get area where scene was called and apply only to lights in that area.
             */

            //Pull service data to string
            Console.WriteLine(sceneevent.Origin);
            string servicedata = Utils.toDataElement(sceneevent.DataElement).service_data.ToString();

            Scene matching_scene = NullScene;

            HomeAssistantGenerated.LightEntities le = new HomeAssistantGenerated.LightEntities(Context.ha);

            //Find matching scene
            foreach (Scene scene in All)
            {
                if (servicedata.Contains(scene.SceneName))
                {
                    matching_scene = scene;
                }
            }
            _setScene(matching_scene, MLight.All);
        }

        public Scene(IHaContext _ha, ILogger _logger, string _SceneName, float _UpdateSeconds, SceneAction _Action) : this(_ha, _logger, _SceneName, _Action)
        {
            UpdateTimeMS = (int)(1000 * float.Parse(Settings.ReadSetDefault("Settings", "UpdateSeconds", _UpdateSeconds.ToString())));
        }

        /// <summary>
        /// Sets the theme of each light in lights to scene s
        /// </summary>
        /// <param name="s"></param>
        /// <param name="lights"></param>
        private static void _setScene(Scene s, List<MLight> lights)
        {
            Console.WriteLine("Scene Set: " + s.SceneName);

            foreach (MLight l in lights)
            {
                //Deactivate Custom Layer
                l.Custom.isActive = false;
                //Overwrite current scene with new scene.
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

        //Determine if current scene is in use anywhere
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

        /// <summary>
        /// Run scene action on lights with scene active
        /// </summary>
        private void InvokeAction()
        {
            if (CheckActive())
                Action.Invoke(Settings, GetActiveLights());
            else
                UpdateTimer.Change(-1, -1);
        }

        /// <summary>
        /// Get list of lights in which the current scene is active
        /// </summary>
        /// <returns></returns>
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
}