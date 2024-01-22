using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logger
{
    public class LogsSender : MonoBehaviour
    {
        private List<ILogger> _loggers = new List<ILogger>(); 

        
        private float currentTime;
        private void Update()
        {
            currentTime += Time.deltaTime;
            if(currentTime >= 1f)
            {
                currentTime = 0;

                foreach(var loggers in _loggers)
                {
                    loggers.Print(loggers.GetType().Name + " " + DateTime.Now.ToString());
                }
            }
        }
        public void Register(ILogger logger)
        {
            _loggers.Add(logger);
        }
    }
}
