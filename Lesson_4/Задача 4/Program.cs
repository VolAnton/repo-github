using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            int numb = GetNumb();            
            Console.WriteLine(GetFeb(numb));
        }
        static int GetNumb()
        {
            Console.WriteLine("Укажите порядок искомой послеодовательности числа Фибоначчи");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int GetFeb(int n)
        {            
            if (n >= 2)
            {
                return (GetFeb(n - 1) + GetFeb(n - 2));
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
