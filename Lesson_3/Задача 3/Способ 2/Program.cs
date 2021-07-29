using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите строчку, нажмите Enter и она будет выведена в обратном порядке тремя способами");
            str = Console.ReadLine();
            char[] rts = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                rts[i] = str[str.Length - 1 - i];
            }
            
            Console.WriteLine();
            Console.WriteLine("Cпособ №1"); // Вывод с помощью цикла for

            for (int i = 0; i < rts.Length; i++)
            {
                Console.Write(rts[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cпособ №2"); // Вывод с помощью цикла foreach
            foreach (char h in rts)
            {
                Console.Write(h);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cпособ №3"); // Вывод с помощью присвоения переменной типа string массива char
            string str2 = new string(rts);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
