using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson3
{
    public class UiTextLogger : MonoBehaviour, ILogger
    {
        [SerializeField] private Text textLogger;

        [SerializeField] private LogsSender _logsSender;

        private void Awake()
        {
            _logsSender.Register(this);
            textLogger.text = " ";
        }

        public void Print(string log)
        {
            
            textLogger.text = textLogger.text + "\n" + log;     
        }
    }
}