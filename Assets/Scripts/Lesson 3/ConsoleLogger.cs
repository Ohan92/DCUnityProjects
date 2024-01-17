using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Cooldown;

namespace Logger
{
    public class ConsoleLogger : MonoBehaviour, ILogger
    {
        [SerializeField] LogsSender logsSender;

        private void Awake(){
            logsSender.Register(this);
        }

        public void Print(string log)
        {
           Debug.Log(log + $"\n {System.DateTime.Now} \n {this}");
        }
    }
}
