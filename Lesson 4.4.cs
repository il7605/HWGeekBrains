using System;

namespace Lesson_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int Fib = GetFib(number);

            Console.WriteLine($"Число Фибоначи для заданного значения = {Fib}");
        }
        static int GetFib(int number)
        {
            if (number == 0|| number == 1)
            {
                return number;
            }
            else
            {
                return GetFib(number - 1) + GetFib(number - 2);
            }
         
            

        }

    }
}
