using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

namespace Logger
{
    public class FileLogger : MonoBehaviour, ILogger
    {
        private  string filePath = Application.dataPath + "/Log.txt";

        [SerializeField] LogsSender logsSender;
        

        private void Awake()
        {
            if(!File.Exists(filePath))
            {
                File.Create(filePath);
            }
                logsSender.Register(this);
            
        }

        public void Print(string log)
        {
            
                 using(StreamWriter writer = new StreamWriter(filePath, true))
            
            
            {
                writer.WriteLine ($"[{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}");

                

                //writer.Write(log + $"\n {System.DateTime.Now} \n {this}");
            }   
            
        }
    }
}
