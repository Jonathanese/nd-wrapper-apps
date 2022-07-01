using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemonWrapper.Lighting;
using NetDaemon.Extensions.Scheduler;
using NetDaemonWrapper.Events;
using NetDaemon;
using System.Drawing;

namespace NetDaemonWrapper.Scene
{
    public class Scene
    {
        private static UInt16 scenecount = 0;
        public readonly UInt16 SceneIdentifier;
        private static bool isRegistered = false;
        public static List<Scene> All = new List<Scene>();
        public readonly string SceneName;

        public delegate void SceneAction();

        public readonly SceneAction Action;

        public Scene(string _SceneName, SceneAction _Action)
        {
            SceneName = "scene." + _SceneName;
            Console.WriteLine("Scene Added: " + SceneName);
            Action = _Action;
            SetSceneEvent();
            scenecount++;
            SceneIdentifier = scenecount;
            All.Add(this);
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
                        Console.WriteLine("Scene Set: " + sd.entity_id);
                        found = true;
                        s.Action.Invoke();
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Scene Not Found: " + sd.entity_id);
                }
            }
        }
    }
}