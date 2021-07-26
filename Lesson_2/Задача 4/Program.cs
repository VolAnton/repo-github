using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            string org = "ЧТУП \"ЛЕВЕЛ\"";
            Console.SetCursorPosition(12, 0);
            Console.WriteLine($"{org}");

            string address = "г.Брест, ул. Карьерная, 12";
            Console.SetCursorPosition(6, 1);
            Console.WriteLine($"{address}");
            Console.WriteLine(" ");

            int fr = 6277;
            long unp = 2916097260017496;
            string line_1 = $"ФР   {fr:D8}  УНП {unp:######### #######}";
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"{line_1}");

            long skno = 300035700;
            long rnp = 210016512;
            string line_2 = $"СКНО {skno} РНП {rnp}";
            Console.SetCursorPosition(0, 4);
            Console.WriteLine($"{line_2}");

            DateTime day = new DateTime(2021, 07, 21, 18, 26, 00);
            string username = "СИСТ. АДМИН.";
            string line_3 = $"{day:g}        {username}";
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"{line_3}");

            int numb = 3570;
            string line_4 = $"ПЛАТЕЖНЫЙ ДОКУМЕНТ BYN          {numb}";
            Console.SetCursorPosition(0, 6);
            Console.WriteLine($"{line_4}");

            string line_5 = "ЧЕК ПРОДАЖИ";
            Console.SetCursorPosition(0, 7);
            Console.WriteLine($"{line_5}");

            string item_1 = "Обои MISTRAL 575183 0,53x10(шт,";
            string line_6 = $"# {item_1}  #";
            Console.SetCursorPosition(0, 8);
            Console.WriteLine($"{line_6}");

            string item_2 = "арт.575183)";
            string line_7 = $"# {item_2}                      #";
            Console.SetCursorPosition(0, 9);
            Console.WriteLine($"{line_7}");

            byte quantity = 3;
            decimal price = 21.06m;
            decimal sum = (quantity * price);
            string line_8 = $"# {quantity} X {price} = {sum}                #";
            Console.SetCursorPosition(0, 10);
            Console.WriteLine($"{line_8}");

            byte low_percent = 20;
            decimal low_price = Math.Round((sum * low_percent / 100), 2);
            string line_9 = $"# (СКИДКА = {low_price})                 #";
            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"{line_9}");

            decimal total = sum - low_price;
            string line_10 = $"                              ={total}";
            Console.SetCursorPosition(0, 12);
            Console.WriteLine($"{line_10}");

            string line_11 = $"{day:g}       ЗАКРЫТИЕ ЧЕКА";
            Console.SetCursorPosition(0, 13);
            Console.WriteLine($"{line_11}");

            decimal all_total = total;
            string line_12 = $"ВСЕГО                         ={all_total}";
            Console.SetCursorPosition(0, 14);
            Console.WriteLine($"{line_12}");

            string line_13 = $"ИТОГ                          ={all_total}";
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"{line_13}");

            string payment_type = "ПЛАТ. КАРТОЙ";
            string line_14 = $" {payment_type}                 ={all_total}";
            Console.SetCursorPosition(0, 16);
            Console.WriteLine($"{line_14}");
            Console.WriteLine(" ");

            string line_15 = "Спасибо за покупку!                 ";
            Console.SetCursorPosition(0, 18);
            Console.WriteLine($"{line_15}");

            Console.ReadKey();
        }
    }
}
