using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            int next_string = 0;
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = next_string + 1;

                    Console.SetCursorPosition(next_string, next_string);
                    Console.WriteLine(array[i, j]);

                    // Так же вместо строк 18 и 19 можно использовть строку ниже, результат будет тот же
                    //Console.WriteLine($"{new string(' ', next_string)}{array[i, j]}");

                    next_string++;
                }
            }
            Console.ReadKey();
        }
    }
}
