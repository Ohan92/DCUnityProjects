using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Lesson4
{
    public class ConsoleLogger : AbstractLogger
    {
        [SerializeField] LogsSender logsSender;

        private  void Awake(){
            logsSender.Register(this);
        }

        public override void Print(string log)
        {
           Debug.Log($"\n [{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}");
        }
    }
}
