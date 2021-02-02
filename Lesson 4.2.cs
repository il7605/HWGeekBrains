using System;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа через пробел ");
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' });

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int n = Convert.ToInt32(numbers[i]);
                sum += n;
            }

            Console.WriteLine(sum);
        }

    }
}
