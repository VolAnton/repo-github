using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string[,] phones = new string[5, 2];
            Console.WriteLine(@"Это программа телефонный справочник.
Вам нужно заполнить записи по очереди, в конце каждого ввода данных нажать Enter");

            for (int i = 0; i < phones.GetLength(0); i++)
            {
                Console.WriteLine($"Запись №{i + 1}");
                for (int j = 0; j < phones.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Введите имя:");
                        phones[i, j] = Console.ReadLine();
                    }
                    if (j == 1)
                    {
                        Console.WriteLine("Введите номер или E-mail:");
                        phones[i, j] = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Телефонный справочник");
            Console.WriteLine();
            Console.WriteLine("№ записи |         Имя         |     Номер или E-mail    |");

            for (int i = 0; i < phones.GetLength(0); i++)
            {
                Console.WriteLine($"       {i + 1:D2}| {phones[i, 0],20}|{phones[i, 1],25}|");
            }
            Console.ReadKey();
        }
    }
}
