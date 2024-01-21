using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson4
{
    public class LogsSender : MonoBehaviour
    {
            private List<AbstractLogger> _loggers = new List<AbstractLogger>(); 

            
            private float currentTime;
            private void Update()
            {
                currentTime += Time.deltaTime;
                if(currentTime > 1)
                {
                    currentTime = 0;

                    foreach(var loggers in _loggers)
                    {
                        loggers.Print("hi");
                    }
                }
            }
            public void Register(AbstractLogger logger)
            {
                _loggers.Add(logger);
            }
        }
}



