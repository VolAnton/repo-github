using System;

namespace Lessons
{
    class Program
    {
        public enum ErrorCodes
        {
            MyArraySizeException,
            MyArrayDataException
        }
        public class MyArrayDataException : Exception
        {
            public MyArrayDataException(ErrorCodes code)
            {
                Code = code;
            }
            public ErrorCodes Code { get; }
        }
        static void Main(string[] args)
        {
            int[] errorPosition = new int[2];

            // Массив размером 4х4 где все числа
            string[,] array = new string[4, 4] { { "11", "12", "13", "14" }, { "21", "22", "23", "24" }, { "31", "32", "33", "34" }, { "41", "42", "43", "44" } };

            // Массив размером 4х4 где в одной ячейке присутствует строка
            //string[,] array = new string[4, 4] { { "11", "12", "13", "14" }, { "21", "22", "строка", "24" }, { "31", "32", "33", "34" }, { "41", "42", "43", "44" } };

            // Массив размера 3х4
            //string[,] array = new string[3, 4] { { "11", "12", "13", "14" }, { "21", "22", "23", "24" }, { "31", "32", "33", "34" } };

            try
            {
                MyArray(array, errorPosition);
            }
            catch (MyArrayDataException ex) when (ex.Code == ErrorCodes.MyArraySizeException)
            {
                Console.WriteLine("Массив другого размера, введите массив размером 4х4");
            }
            catch (MyArrayDataException ex) when (ex.Code == ErrorCodes.MyArrayDataException)
            {
                Console.WriteLine($"В ячейке [{errorPosition[0] + 1},{errorPosition[1] + 1}] лежат неверные данные (символ или текст вместо числа)");
            }
        }

        static void MyArray(string[,] myArray, int[] error)
        {
            if (myArray.GetLength(0) == 4 && myArray.GetLength(1) == 4)
            {
                int x;
                int sum = 0;
                int[] errorHeap = error;

                int[,] intSumArray = new int[myArray.GetLength(0), myArray.GetLength(1)];
                for (int i = 0; i < intSumArray.GetLength(0); i++)
                {
                    for (int j = 0; j < intSumArray.GetLength(1); j++)
                    {
                        if (Int32.TryParse(myArray[i, j], out x))
                        {
                            intSumArray[i, j] = x;
                            sum += x;
                        }
                        else
                        {
                            errorHeap[0] = i;
                            errorHeap[1] = j;
                            throw new MyArrayDataException(ErrorCodes.MyArrayDataException);
                        }
                    }
                }
                Console.WriteLine($"Сумма всех элементов массива равна: {sum}");
            }
            else
            {
                throw new MyArrayDataException(ErrorCodes.MyArraySizeException);
            }
        }
    }
}
