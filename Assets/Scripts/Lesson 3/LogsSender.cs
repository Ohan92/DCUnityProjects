using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Lesson3
{
    public class LogsSender : MonoBehaviour
    {
        private List<ILogger> _loggers = new List<ILogger>();
        private float time;
        private void Update()
        {
            time = time + Time.deltaTime;
            if(time > 1)
            {
                time = 0;

                foreach(ILogger logger in _loggers)
                {
                    logger.Print(logger.GetType().Name + " " + DateTime.Now.ToString());
                }
            }

        }
        public void Register(ILogger logger)
        {
            _loggers.Add(logger);
        }
    }
}
