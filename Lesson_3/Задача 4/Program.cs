using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string[,] xo = new string[10, 10];            
            char[] xx = { ' ', 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'к' };
            int[] yy = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.SetCursorPosition(1, 0);

            foreach (char h in xx)
            {
                Console.Write($"{h} ");
            }
            
            for (int i = 0; i < yy.Length; i++)
            {
                Console.SetCursorPosition(0, 1 + i);
                Console.Write(yy[i]);
            }
            
            for (int i = 0; i < xo.GetLength(0); i++)
            {                
                for (int j = 0; j < xo.GetLength(1); j++)
                {
                    xo[i, j] = "0";                                        
                }                
            }

            // В игре "Морской бой" есть корабли занимающие 1, 2, 3 и 4 клетки. Создадим их.
            // Корабль на 1 клетку (4 шт.)
            xo[1, 4] = "X";
            xo[7, 7] = "X";
            xo[8, 1] = "X";
            xo[9, 8] = "X";

            // Корабль на 2 клетки (3 шт.)
            xo[1, 1] = "X";
            xo[2, 1] = "X";

            xo[3, 8] = "X";
            xo[4, 8] = "X";

            xo[6, 2] = "X";
            xo[6, 3] = "X";

            // Корабль на 3 клетки (2 шт.)
            xo[1, 7] = "X";
            xo[1, 8] = "X";
            xo[1, 9] = "X";

            xo[3, 3] = "X";
            xo[3, 4] = "X";
            xo[3, 5] = "X";

            // Корабль на 4 клетки (1 шт.)
            xo[5, 5] = "X";
            xo[6, 5] = "X";
            xo[7, 5] = "X";
            xo[8, 5] = "X";

            for (int i = 0; i < xo.GetLength(0); i++)
            {
                Console.SetCursorPosition(3, 1 + i);
                for (int j = 0; j < xo.GetLength(1); j++)
                {                    
                    Console.Write(xo[i, j] + " ");
                }                
            }
            Console.ReadKey();
        }
    }
}
