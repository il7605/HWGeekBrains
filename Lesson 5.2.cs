using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO.Compression;
using System.Text;

namespace Lesson_5._2
{
    class Files
    {
        static void Main(string[] args)
        {
          
            string filename = "startup.txt";
            
            DateTime Time = new DateTime();
            Time = DateTime.Now;

            
            File.AppendAllText(filename, $" {Time.ToString("HH:mm:ss")}" );
        }
    }
}
