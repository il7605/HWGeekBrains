using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}");

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Введите ваше имя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();

            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserAge))
            {

                Console.WriteLine("Введите ваш возраст:");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                Properties.Settings.Default.Save();

            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserWork))
            {

                Console.WriteLine("Кто вы по профессии:");
                Properties.Settings.Default.UserWork = Console.ReadLine();
                Properties.Settings.Default.Save();

            }
            string userName = Properties.Settings.Default.UserName;
            string userAge = Properties.Settings.Default.UserAge;
            string userWork = Properties.Settings.Default.UserWork;
            Console.WriteLine($"{userName}, {userAge}, {userWork}");

            Console.ReadKey();
        }
    }
}
