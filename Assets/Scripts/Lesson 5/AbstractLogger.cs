using UnityEngine;

namespace Lesson5
{
    public abstract class AbstractLogger : MonoBehaviour
    {
        [SerializeField] protected LogType logType;

        public abstract void Print(LogType logType, string log);
        
       
        public LogType LogType => logType;
    }
}


