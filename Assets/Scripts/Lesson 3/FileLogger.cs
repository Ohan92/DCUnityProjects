using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Logger
{
    public class FileLogger : MonoBehaviour, ILogger
    {
        private string filePath = "Assets/Log.txt";

        [SerializeField] LogsSender logsSender;

        private void Awake(){
            logsSender.Register(this);
        }

        public void Print(string log)
        {
            using(StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(log + $"\n {System.DateTime.Now} \n {this}");
            }   
        }
    }
}
