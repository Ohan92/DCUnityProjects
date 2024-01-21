using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson5
{
    public abstract class AbstractLogger : MonoBehaviour
    {
        [SerializeField] protected string inspectorLogMes;
        [SerializeField] protected LogType logType;
        public abstract void Print(LogType logType, string log);
        
    }

}

