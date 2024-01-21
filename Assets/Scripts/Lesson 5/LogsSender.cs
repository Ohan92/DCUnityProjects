using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson5
{
    public class LogsSender : MonoBehaviour
    {
            private List<AbstractLogger> _loggers = new List<AbstractLogger>(); 
            [SerializeField] ReactiveLogger reactiveLogger;

            
            private float currentTime;
            private LogType currentLogType = LogType.Log;
            private void Update()
            {
                currentTime += Time.deltaTime;
                if(currentTime > 1)
                {
                    currentTime = 0;

                    
                    
                        reactiveLogger.OnLog.Invoke(currentLogType,"HI");

                    
                    currentLogType = (LogType) (((int) currentLogType + 1) % 3);
                }
            }
            public void Register(AbstractLogger logger)
            {
                _loggers.Add(logger);
                reactiveLogger.OnLog += logger.Print;
            }
        }
}



