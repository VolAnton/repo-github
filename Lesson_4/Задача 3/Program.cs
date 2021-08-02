using System;

namespace Lessons
{
    class Program
    {
        public enum month
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }

        static void Main(string[] args)
        {
            int monthNumber = MonthNumber();
            month season = GetSeason(monthNumber);
            PrintSeason(season);
        }
        static int MonthNumber()
        {
            Console.WriteLine("Введите порядковый номер месяца");
            return Convert.ToInt32(Console.ReadLine());
        }

        static month GetSeason(int monthNumber)
        {
            month result = new month();
            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    result = month.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    result = month.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    result = month.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    result = month.Autumn;
                    break;
                default:
                    break;
            }
            return result;
        }

        static void PrintSeason(month season)
        {
            switch ((int)season)
            {
                case 1:
                    Console.WriteLine("Зима");
                    break;
                case 2:
                    Console.WriteLine("Весна");
                    break;
                case 3:
                    Console.WriteLine("Лето");
                    break;
                case 4:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    break;
            }
        }
    }
}
