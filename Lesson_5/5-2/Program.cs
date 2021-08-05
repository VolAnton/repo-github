using System;
using System.IO;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            Startup();
            Console.WriteLine($"Мы только что дописали текущее время {DateTime.Now.ToShortTimeString()} в файл startup.txt");
        }
        static void Startup()
        {
            string[] time = { Convert.ToString(DateTime.Now.ToShortTimeString()) };
            File.AppendAllLines("startup.txt", time);
        }
    }
}
