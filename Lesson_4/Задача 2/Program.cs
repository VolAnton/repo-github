using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string numbers = InputNumbers();
            GetSummNumbers(numbers);
        }
        static string InputNumbers()
        {
            Console.WriteLine("Введите чисела, разделенные пробелом, нажмите Enter и получите сумму всех чисел ");
            string input = Convert.ToString(Console.ReadLine());
            return input;
        }

        static void GetSummNumbers(string numb)
        {
            string[] wordNumb = numb.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            Console.WriteLine("Были введены следующие числа:");
            for (int i = 0; i < wordNumb.Length; i++)
            {
                Console.Write(wordNumb[i] + " ");
                result += Convert.ToInt32(wordNumb[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма всех введенных чисел равна = {result}");
        }
    }
}
