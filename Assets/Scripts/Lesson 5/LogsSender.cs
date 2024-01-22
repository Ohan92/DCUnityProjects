using System.Collections.Generic;
using UnityEngine;

namespace Lesson5
{
    public class LogsSender : MonoBehaviour
    {
        private List<AbstractLogger> _loggers = new List<AbstractLogger>();
        [SerializeField] private ReactiveLogger reactiveLogger;

        private void Start()
        {
            reactiveLogger.OnLog += HandleLog;
        }

        private void HandleLog(LogType logType, string log)
        {
            foreach (var logger in _loggers)
            {
                if (logger.LogType == logType)
                {
                    logger.Print(logType, log);
                }
            }
        }

        public void Register(AbstractLogger logger)
        {
            _loggers.Add(logger);
        }
    }
}






