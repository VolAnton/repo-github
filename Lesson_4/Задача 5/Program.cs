using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            String str1 = " Предложение один Теперь предложение два Предложение три";
            GetPunctuation(str1);
        }
        static void GetPunctuation(string text)
        {
            char ind = ' ';
            string point = ".";
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == ind && char.IsUpper(text[i + 1]))
                {
                    if (char.IsPunctuation(text[i - 1]) && text[i] == ind && char.IsUpper(text[i + 1]))
                    {
                        continue;
                    }
                    text = text.Insert(i, point);
                }                
            }            
            Console.WriteLine(text);
        }
    }
}
