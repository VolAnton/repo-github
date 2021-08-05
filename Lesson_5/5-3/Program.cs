using System;
using System.IO;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = InputStringOfBytes();
            SaveByteInFile(input, "Byte.bin");
        }        
        static string InputStringOfBytes()
        {
            Console.WriteLine("Введите числа от 0 до 255, разделенные пробелом, нажмите Enter и они будут записаны в файл Byte.bin");
            string input = Convert.ToString(Console.ReadLine());
            return input;
        }
        static void SaveByteInFile(string byteString, string filename)
        {
            string[] myStringBytes = byteString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] myBytes = new byte[myStringBytes.Length];            
            for (int i=0; i < myBytes.Length; i++)
            {
                myBytes[i] = (byte)Convert.ToByte(myStringBytes[i]);
            }
            File.WriteAllBytes(filename, myBytes);
        }

    }
}
