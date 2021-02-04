using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Lesson_5._3
{
    class Files
    {
        static void Main()
        {
            Console.WriteLine("Введите числа от 0 до 255");
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' });
           
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), numbers);

        }
    }
}
