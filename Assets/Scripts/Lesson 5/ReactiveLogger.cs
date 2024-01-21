using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson5
{
    public class ReactiveLogger : MonoBehaviour
    {
        public Action<LogType,string> OnLog;
    }

   public enum LogType 
    {
        Log,
        Warning,
        Error
    }

}

