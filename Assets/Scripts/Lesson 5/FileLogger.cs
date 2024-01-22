using System;
using System.IO;
using UnityEngine;

namespace Lesson5
{
    public class FileLogger : AbstractLogger
    {
        [SerializeField] private ReactiveLogger reactiveLogger;
        private string path;

        private void OnEnable()
        {
            if (reactiveLogger != null)
            {
                reactiveLogger.OnLog += Print;
            }
        }

        private void OnDisable()
        {
            if (reactiveLogger != null)
            {
                reactiveLogger.OnLog -= Print;
            }
        }

        private void Awake()
        {
            
            path = Path.Combine(Application.dataPath, "Scripts", "Lesson5");
            Directory.CreateDirectory(path);

            path = Path.Combine(path, "Log.txt");

            if (!File.Exists(path))
            {
                
                File.Create(path).Close();
            }
            
            File.WriteAllText(path, "");
        }

        public override void Print(LogType logsType, string log)
        {
            if (logsType == logType)
            {
                log = log + "\n";
                File.AppendAllText(path, log);
            }
        }
    }
}
