using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using static Unity.VisualScripting.Cooldown;

namespace Logger
{
    public class ConsoleLogger : MonoBehaviour, ILogger
    {
        [SerializeField] LogsSender logsSender;

       public void Print (string log) 
        {
            Debug.Log(log);
        }
        private void Awake ()
        {
            logsSender.Register(this);
        }
    }
}
