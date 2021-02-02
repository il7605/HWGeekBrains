using System;

namespace Lesson_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fNameOne = GetFirstName();
            string lNameOne = GetLastName();
            string patrOne = GetPatronymic();
            string fullNameOne = GetFullName(fNameOne, lNameOne, patrOne);
            Console.WriteLine(fullNameOne);

            string fNameTwo = GetFirstName();
            string lNameTwo = GetLastName();
            string patrTwo = GetPatronymic();
            string fullNameTwo = GetFullName(fNameTwo, lNameTwo, patrTwo);
            Console.WriteLine(fullNameTwo);

            string fNameThree = GetFirstName();
            string lNameThree = GetLastName();
            string patrThree = GetPatronymic();
            string fullNameThree = GetFullName(fNameThree, lNameThree, patrThree);
            Console.WriteLine(fullNameThree);

            string fNameFour = GetFirstName();
            string lNameFour = GetLastName();
            string patrFour = GetPatronymic();
            string fullNameFour = GetFullName(fNameFour, lNameFour, patrFour);
            Console.WriteLine(fullNameFour);

            string fNameFive = GetFirstName();
            string lNameFive = GetLastName();
            string patrFive = GetPatronymic();
            string fullNameFive = GetFullName(fNameFive, lNameFive, patrFive);
            Console.WriteLine(fullNameFive);
        }
    
         static string GetFirstName()
        {
            Console.WriteLine("Введит имя ");
            string firstName = Console.ReadLine();
            return firstName;
        }
        static string GetLastName()
        {
            Console.WriteLine("Введит отчество ");
            string lastName = Console.ReadLine();
            return lastName;
        }
        static string GetPatronymic()
        {
            Console.WriteLine("Введит фамилию ");
            string patronymic = Console.ReadLine();
            return patronymic;
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{patronymic} {firstName} {lastName}";
        }
    }
}

