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

            
            string HomeWok5 = @"C:\HomeWok5";

            Console.WriteLine(Path.GetFileName(HomeWok5));

            string Documents = @"C:\HomeWok5\Documents";

            Console.WriteLine(Path.GetFileName(Documents));

            string Files = @"C:\HomeWok5\Documents\Files";

            Console.WriteLine(Path.GetFileName(Files));

            string file = @"C:\HomeWok5\Documents\Files\File 1.txt";

            Console.WriteLine(Path.GetFileName(file));

            string filename = "text.txt";
            
            File.AppendAllLines(filename, new[] { HomeWok5, Documents, Files, file });


        }


    }

}
