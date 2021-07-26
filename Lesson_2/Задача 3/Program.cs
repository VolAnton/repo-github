using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Введите целое число и нажмите Enter");

            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 1)
            {
                Console.WriteLine($"Введенное число {number} является нечетным");
            }
            else
            {
                Console.WriteLine($"Введенное число {number} является четным");
            }

            Console.ReadKey();
        }
    }
}
