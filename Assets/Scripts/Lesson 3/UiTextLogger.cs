using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Logger
{
    public class UiTextLogger : MonoBehaviour, ILogger
    {
        [SerializeField] Text textLogger;

        [SerializeField] LogsSender logsSender;

        private void Awake(){
            logsSender.Register(this);
        }

        public void Print(string log)
        {
            textLogger.text = log + $"\n {System.DateTime.Now} \n {this}";
        }
    }
}