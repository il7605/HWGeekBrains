using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO.Compression;
using System.Text;

namespace Lesson_5._1
{
    class Files
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            string strl = Console.ReadLine();
            File.WriteAllText(filename, strl);

            File.AppendAllText(filename, Environment.NewLine);
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            File.AppendAllLines(filename, new[] { str2, str3 });

            string fileText = File.ReadAllText(filename);

            string[] fileLines = File.ReadAllLines(filename);

            

        }
    }
}
