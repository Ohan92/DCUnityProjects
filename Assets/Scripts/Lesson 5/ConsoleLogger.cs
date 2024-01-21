using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Lesson5
{
    public class ConsoleLogger : AbstractLogger
    {
        [SerializeField] LogsSender logsSender;
        

        private  void Awake(){
            logsSender.Register(this);
        }

        public override void Print(LogType logType,string log)
        {
           Debug.Log($"\n {logType}:[{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}");
        }
    }
}
