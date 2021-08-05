using System;
using System.IO;


namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = TextFromKbd();
            TextSaveIntoFile(text);
        }
        static string TextFromKbd()
        {
            Console.WriteLine("Введите произвольный набор данных, нажмите Enter и он будет сохранен в файл Text.txt");
            return (string)Console.ReadLine();
        }
        static void TextSaveIntoFile(string txt)
        {
            string filename = "Text.txt";
            File.WriteAllText(filename, txt);
        }
    }
}
