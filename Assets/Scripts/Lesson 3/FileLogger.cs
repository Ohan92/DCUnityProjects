using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

namespace Lesson3
{
    public class FileLogger : MonoBehaviour, ILogger
    {
        private  string Path = Application.dataPath + "/Log.txt";
        [SerializeField] private LogsSender _logsSender;
        private void Awake()
        {
            if(!File.Exists(Path))
            {
                File.Create(Path);
            }
            _logsSender.Register(this);
            
        }

        public void Print(string log)
        {
            
            using(StreamWriter writer = new StreamWriter(Path, true))
            {
                writer.WriteLine ($"[{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}");
            }   
            
        }
    }
}