﻿using System;
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
            SubscribeScene();
        }

        /// <summary>
        /// Add listener for when scene is called.
        /// </summary>
        private void SubscribeScene()
        {
            try
            {
                //TODO: Currently passes all lights.
                //Subscribe to this scene service call event

                Context.ha.Events
                    .Where(e => e.EventType == "call_service")
                    .Where(e => Utils.toDataElement(e.DataElement).domain == "scene")
                    .Where(e => Utils.toServiceData(Utils.toDataElement(e.DataElement).service_data).entity_id == SceneName)
                .Subscribe(s => _setScene(this, MLight.All));
            }
            catch
            {
                Console.WriteLine("Subscribe Failed: " + SceneName);
            }
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