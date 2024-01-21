using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson4
{
    public class UiTextLogger : AbstractLogger
    {
        [SerializeField] Text textLogger;

        [SerializeField] LogsSender logsSender;

        private void Awake()
        {
            logsSender.Register(this);
        }

        public override void Print(string log)
        {
            //textLogger.text = log + $"\n {System.DateTime.Now} \n {this}";
            textLogger.text += $"\n [{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}";
        }
    }
}
