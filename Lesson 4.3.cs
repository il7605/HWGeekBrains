using System;

namespace Lesson_4._3
{
    class Program
    {

        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
           
            string number = Console.ReadLine();
            

            string incrementedBy = Increment(number);
            string incrementedByOne = IncrementOne(number);
            string incrementedByTwo = IncrementTwo(number);
            string incrementedByThree = IncrementThree(number);

            if (NotNum(number, out string error))
            {
                if (number == "12" || number == "1" || number == "2")

                {

                    Console.WriteLine($"Время года {incrementedBy}");
                }
                else if (number == "3" || number == "4" || number == "5")
                {

                    Console.WriteLine($"Время года {incrementedByOne}");
                }
                else if (number == "6" || number == "7" || number == "8")
                {

                    Console.WriteLine($"Время года {incrementedByTwo}");
                }
                else if (number == "9" || number == "10" || number == "11")
                {

                    Console.WriteLine($"Время года {incrementedByThree}");
                }
            }
            else
            {
                Console.WriteLine(error);
            }

        }

        static string Increment(string value)
        
        {
            string[] nameSeason = { "Зима", "Весна", "Лето", "Осень" };
            Season oneSeason = Season.Winter;
            Season twoSeason = Season.Spring;
            Season threeSeason = Season.Summer;
            Season fourSeason = Season.Autumn;
            
            return value = nameSeason[(int)oneSeason];
            
        }
        static string IncrementOne(string value)

        {
            string[] nameSeason = { "Зима", "Весна", "Лето", "Осень" };
            Season oneSeason = Season.Winter;
            Season twoSeason = Season.Spring;
            Season threeSeason = Season.Summer;
            Season fourSeason = Season.Autumn;

            return value = nameSeason[(int)twoSeason];

        }
        static string IncrementTwo(string value)

        {
            string[] nameSeason = { "Зима", "Весна", "Лето", "Осень" };
            Season oneSeason = Season.Winter;
            Season twoSeason = Season.Spring;
            Season threeSeason = Season.Summer;
            Season fourSeason = Season.Autumn;

            return value = nameSeason[(int)threeSeason];

        }
        static string IncrementThree(string value)

        {
            string[] nameSeason = { "Зима", "Весна", "Лето", "Осень" };
            Season oneSeason = Season.Winter;
            Season twoSeason = Season.Spring;
            Season threeSeason = Season.Summer;
            Season fourSeason = Season.Autumn;

            return value = nameSeason[(int)fourSeason];

        }
        static bool NotNum(string number, out string error)
        {
            if (number != "1" || number != "2"|| number != "3"|| number != "4"|| number != "5"|| number != "6"|| number != "7"|| number != "8"|| number != "9"|| number != "10" || number != "11" || number != "12")
            {
                error = "«Ошибка: введите число от 1 до 12»";
                return false;
            }

            error = "";
            return true;
        }

    }










}
