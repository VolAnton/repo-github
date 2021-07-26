using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            int min_t, max_t;
            float average_t;

            Console.WriteLine("Укажите минимальную температуру за сутки в градусах и нажмите Enter");
            min_t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите максимальную температуру за сутки в градусах и нажмите Enter");
            max_t = Convert.ToInt32(Console.ReadLine());

            average_t = (float)(max_t + min_t) / 2;

            Console.WriteLine($"Среднесуточная температура равна {average_t} градусов");

            Console.ReadKey();
        }
    }
}
