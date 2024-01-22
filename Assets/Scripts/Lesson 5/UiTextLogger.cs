using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson5
{
    public class UiTextLogger : AbstractLogger
    {
        [SerializeField] private Text textLogger;
        [SerializeField] private ReactiveLogger reactiveLogger;

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

        public override void Print(LogType logType, string log)
        {
            textLogger.text += $"\n {logType}:[{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}";
        }
    }
}
