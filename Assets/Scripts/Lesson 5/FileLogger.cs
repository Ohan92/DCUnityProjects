using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

namespace Lesson5
{
    public class FileLogger : AbstractLogger
    {
            private  string filePath = Application.dataPath + "/LogLesson4.txt";

            [SerializeField] LogsSender logsSender;
            
            

            private void Awake()
            {
                if(!File.Exists(filePath))
                {
                    File.Create(filePath);
                }
                    logsSender.Register(this);
                
            }

            public override void Print(LogType logType,string log)
            {
                
                    using(StreamWriter writer = new StreamWriter(filePath, true))
                
                
                {
                    writer.WriteLine ($"{logType}:[{DateTime.Now.ToString(CultureInfo.InvariantCulture)}] :: {GetType().Name} Logged: {log}");

                    

                    
                }   
                
            }
    }
}




