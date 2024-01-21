using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System;

namespace Logger
{
    public class UiTextLogger : MonoBehaviour, ILogger
    {
        [SerializeField] Text textLogger;

        [SerializeField] LogsSender logsSender;

        private void Awake()
        {
            logsSender.Register(this);
        }

        public void Print(string log)
        {
            //textLogger.text = log + $"\n {System.DateTime.Now} \n {this}";
            textLogger.text += $"\n [{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}";
        }
    }
}