using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите строчку, нажмите Enter и она будет выведена в обратном порядке");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[str.Length - 1 - i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
