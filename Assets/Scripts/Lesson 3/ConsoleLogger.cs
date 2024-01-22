using System.Collections;
using UnityEngine;

namespace Lesson3 
{
    public class ConsoleLogger : MonoBehaviour, ILogger
    {
        [SerializeField] private LogsSender _logsSender;
    
        public void Print (string log) 
        {
            Debug.Log(log);
        }
        private void Awake ()
        {
            _logsSender.Register(this);
        }
    }
}
