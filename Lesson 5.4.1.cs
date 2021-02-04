using System;
using System.IO;

namespace Lesson_5._4
{
    class Files
    {
        static void Main(string[] args)
        {
            string workDir = @"C:\HomeWok5";

            Console.WriteLine(Directory.Exists(workDir));

            string notesDir = Path.Combine(workDir, "Files");

            Directory.CreateDirectory(notesDir);

            string noteText = "1 файл";

            string notePath = Path.Combine(notesDir, "File 1.txt");

            File.WriteAllText(notePath, noteText);

            Directory.CreateDirectory(Path.Combine(workDir, "Documents"));

            Directory.Move(notesDir, Path.Combine(workDir, "Documents", "Files"));

            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

            int i = 4;

            int Dir = Direct(i);

            string filename = "text.txt";

            File.WriteAllText(filename, $"{entries[Dir]}");

        }
        static int Direct(int i)
        {
            if (i == 2) 
            {
                return i;
            }
            return Direct(i-1); 
        }


    }
}
