using System;

namespace Lessons
{
    class Program
    {
        public enum all_months
        {
            Январь,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            int min_t, max_t;
            float average_t;
            int month;

            Console.WriteLine("Укажите минимальную температуру за сутки в градусах и нажмите Enter");
            min_t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите максимальную температуру за сутки в градусах и нажмите Enter");
            max_t = Convert.ToInt32(Console.ReadLine());

            average_t = (float)(max_t + min_t) / 2;

            Console.WriteLine($"Среднесуточная температура равна {average_t} градусов");

            Console.WriteLine("Укажите порядковый номер текущего месяца и нажмите Enter");

            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine(all_months.Январь);
                    if (average_t > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 2:
                    Console.WriteLine(all_months.Февраль);
                    if (average_t > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 3:
                    Console.WriteLine(all_months.Март);
                    break;
                case 4:
                    Console.WriteLine(all_months.Апрель);
                    break;
                case 5:
                    Console.WriteLine(all_months.Май);
                    break;
                case 6:
                    Console.WriteLine(all_months.Июнь);
                    break;
                case 7:
                    Console.WriteLine(all_months.Июль);
                    break;
                case 8:
                    Console.WriteLine(all_months.Август);
                    break;
                case 9:
                    Console.WriteLine(all_months.Сентябрь);
                    break;
                case 10:
                    Console.WriteLine(all_months.Октябрь);
                    break;
                case 11:
                    Console.WriteLine(all_months.Ноябрь);
                    break;
                case 12:
                    Console.WriteLine(all_months.Декабрь);
                    if (average_t > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                default:
                    Console.WriteLine("Такого месяца нет, укажите месяц от 1 до 12");
                    break;
            }

            Console.ReadKey();
        }
    }
}
