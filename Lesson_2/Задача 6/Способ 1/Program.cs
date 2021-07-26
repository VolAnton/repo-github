using System;

namespace Lessons
{
    class Program
    {
        [Flags]
        public enum weekDays
        {
            Monday = 0b_1,
            Tuesday = 0b_10,
            Wednesday = 0b_100,
            Thursday = 0b_1000,
            Friday = 0b_10000,
            Saturday = 0b_100000,
            Sunday = 0b_1000000
        }
        static void Main(string[] args)
        {
            // Задаем маски режима работы, work_1_7 - "1" означает понедельник, "7" - воскресенье, получается работа с понедельника до воскресенья,
            // например work_4_7 - работа с четверга до воскресенья, work_3_4 - работа со среды до чертверга.
            weekDays work_1_7 = weekDays.Monday | weekDays.Sunday;
            weekDays work_1_6 = weekDays.Monday | weekDays.Saturday;
            weekDays work_1_5 = weekDays.Monday | weekDays.Friday;
            weekDays work_1_4 = weekDays.Monday | weekDays.Thursday;
            weekDays work_1_3 = weekDays.Monday | weekDays.Wednesday;
            weekDays work_1_2 = weekDays.Monday | weekDays.Tuesday;
            weekDays work_2_7 = weekDays.Tuesday | weekDays.Sunday;
            weekDays work_2_6 = weekDays.Tuesday | weekDays.Saturday;
            weekDays work_2_5 = weekDays.Tuesday | weekDays.Friday;
            weekDays work_2_4 = weekDays.Tuesday | weekDays.Thursday;
            weekDays work_2_3 = weekDays.Tuesday | weekDays.Wednesday;
            weekDays work_3_7 = weekDays.Wednesday | weekDays.Sunday;
            weekDays work_3_6 = weekDays.Wednesday | weekDays.Saturday;
            weekDays work_3_5 = weekDays.Wednesday | weekDays.Friday;
            weekDays work_3_4 = weekDays.Wednesday | weekDays.Thursday;
            weekDays work_4_7 = weekDays.Thursday | weekDays.Sunday;
            weekDays work_4_6 = weekDays.Thursday | weekDays.Saturday;
            weekDays work_4_5 = weekDays.Thursday | weekDays.Friday;
            weekDays work_5_7 = weekDays.Friday | weekDays.Sunday;
            weekDays work_5_6 = weekDays.Friday | weekDays.Saturday;
            weekDays work_6_7 = weekDays.Saturday | weekDays.Sunday;

            // Задаем дни работы офисов, в примере рассматриваем 10 офисов. Режим работы задается указанием начального дня работы и конечного дня.
            // например, 0b_1001 - начальный день понедельник, конечный - четверг; 0b_100010 - начальный - вторник, конечный - суббота.
            weekDays office_1 = (weekDays)0b_1000001;
            weekDays office_2 = (weekDays)0b_101;
            weekDays office_3 = (weekDays)0b_11;
            weekDays office_4 = (weekDays)0b_10100;
            weekDays office_5 = (weekDays)0b_1000100;
            weekDays office_6 = (weekDays)0b_10010;
            weekDays office_7 = (weekDays)0b_1001;
            weekDays office_8 = (weekDays)0b_10001;
            weekDays office_9 = (weekDays)0b_100001;
            weekDays office_10 = (weekDays)0b_1001000;

            // Для удобства работы создаём одномерный массив для каждого офиса
            weekDays[] office = new weekDays[10];
            office[0] = office_1;
            office[1] = office_2;
            office[2] = office_3;
            office[3] = office_4;
            office[4] = office_5;
            office[5] = office_6;
            office[6] = office_7;
            office[7] = office_8;
            office[8] = office_9;
            office[9] = office_10;

            // Создаем одномерный массив для хранения результатов проверки с каким масками режима работы совпадают дни работы офиса
            weekDays[] do_office_1_7 = new weekDays[10];
            weekDays[] do_office_1_6 = new weekDays[10];
            weekDays[] do_office_1_5 = new weekDays[10];
            weekDays[] do_office_1_4 = new weekDays[10];
            weekDays[] do_office_1_3 = new weekDays[10];
            weekDays[] do_office_1_2 = new weekDays[10];
            weekDays[] do_office_2_7 = new weekDays[10];
            weekDays[] do_office_2_6 = new weekDays[10];
            weekDays[] do_office_2_5 = new weekDays[10];
            weekDays[] do_office_2_4 = new weekDays[10];
            weekDays[] do_office_2_3 = new weekDays[10];
            weekDays[] do_office_3_7 = new weekDays[10];
            weekDays[] do_office_3_6 = new weekDays[10];
            weekDays[] do_office_3_5 = new weekDays[10];
            weekDays[] do_office_3_4 = new weekDays[10];
            weekDays[] do_office_4_7 = new weekDays[10];
            weekDays[] do_office_4_6 = new weekDays[10];
            weekDays[] do_office_4_5 = new weekDays[10];
            weekDays[] do_office_5_7 = new weekDays[10];
            weekDays[] do_office_5_6 = new weekDays[10];
            weekDays[] do_office_6_7 = new weekDays[10];

            // Проверка какие дни работы присутствуюет в офисе (с какими масками режима работы совпадают дни работы офиса)
            for (int j = 0; j < office.Length; j++)
            {
                do_office_1_2[j] = work_1_2 & office[j];
                do_office_1_3[j] = work_1_3 & office[j];
                do_office_1_4[j] = work_1_4 & office[j];
                do_office_1_5[j] = work_1_5 & office[j];
                do_office_1_6[j] = work_1_6 & office[j];
                do_office_1_7[j] = work_1_7 & office[j];
                do_office_2_3[j] = work_2_3 & office[j];
                do_office_2_4[j] = work_2_4 & office[j];
                do_office_2_5[j] = work_2_5 & office[j];
                do_office_2_6[j] = work_2_6 & office[j];
                do_office_2_7[j] = work_2_7 & office[j];
                do_office_3_4[j] = work_3_4 & office[j];
                do_office_3_5[j] = work_3_5 & office[j];
                do_office_3_6[j] = work_3_6 & office[j];
                do_office_3_7[j] = work_3_7 & office[j];
                do_office_4_5[j] = work_4_5 & office[j];
                do_office_4_6[j] = work_4_6 & office[j];
                do_office_4_7[j] = work_4_7 & office[j];
                do_office_5_6[j] = work_5_6 & office[j];
                do_office_5_7[j] = work_5_7 & office[j];
                do_office_6_7[j] = work_6_7 & office[j];
            }

            // Создаем одномерный массив для хранения результатов сравнения (дней работы офиса с масками режима работы)
            bool[] isWork_1_2 = new bool[10];
            bool[] isWork_1_3 = new bool[10];
            bool[] isWork_1_4 = new bool[10];
            bool[] isWork_1_5 = new bool[10];
            bool[] isWork_1_6 = new bool[10];
            bool[] isWork_1_7 = new bool[10];
            bool[] isWork_2_3 = new bool[10];
            bool[] isWork_2_4 = new bool[10];
            bool[] isWork_2_5 = new bool[10];
            bool[] isWork_2_6 = new bool[10];
            bool[] isWork_2_7 = new bool[10];
            bool[] isWork_3_4 = new bool[10];
            bool[] isWork_3_5 = new bool[10];
            bool[] isWork_3_6 = new bool[10];
            bool[] isWork_3_7 = new bool[10];
            bool[] isWork_4_5 = new bool[10];
            bool[] isWork_4_6 = new bool[10];
            bool[] isWork_4_7 = new bool[10];
            bool[] isWork_5_6 = new bool[10];
            bool[] isWork_5_7 = new bool[10];
            bool[] isWork_6_7 = new bool[10];

            // Сравниваем дни работы офиса с масками режима работы, в положительном случае выводим сообщение на экран о режиме работы офиса
            for (int j = 0; j < office.Length; j++)
            {
                isWork_1_2[j] = do_office_1_2[j] == work_1_2;
                if (isWork_1_2[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с понедельника до вторника");
                }
                isWork_1_3[j] = do_office_1_3[j] == work_1_3;
                if (isWork_1_3[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с понедельника до среды");
                }
                isWork_1_4[j] = do_office_1_4[j] == work_1_4;
                if (isWork_1_4[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с понедельника до четверга");
                }
                isWork_1_5[j] = do_office_1_5[j] == work_1_5;
                if (isWork_1_5[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с понедельника до пятницы");
                }
                isWork_1_6[j] = do_office_1_6[j] == work_1_6;
                if (isWork_1_6[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с понедельника до субботы");
                }
                isWork_1_7[j] = do_office_1_7[j] == work_1_7;
                if (isWork_1_7[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с понедельника до воскресенья");
                }
                isWork_2_3[j] = do_office_2_3[j] == work_2_3;
                if (isWork_2_3[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со вторника до среды");
                }
                isWork_2_4[j] = do_office_2_4[j] == work_2_4;
                if (isWork_2_4[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со вторника до четверга");
                }
                isWork_2_5[j] = do_office_2_5[j] == work_2_5;
                if (isWork_2_5[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со вторника до пятницы");
                }
                isWork_2_6[j] = do_office_2_6[j] == work_2_6;
                if (isWork_2_6[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со вторника до субботы");
                }
                isWork_2_7[j] = do_office_2_7[j] == work_2_7;
                if (isWork_2_7[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со вторника до восресенья");
                }
                isWork_3_4[j] = do_office_3_4[j] == work_3_4;
                if (isWork_3_4[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со среды до четверга");
                }
                isWork_3_5[j] = do_office_3_5[j] == work_3_5;
                if (isWork_3_5[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со среды до пятницы");
                }
                isWork_3_6[j] = do_office_3_6[j] == work_3_6;
                if (isWork_3_6[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со среды до субботы");
                }
                isWork_3_7[j] = do_office_3_7[j] == work_3_7;
                if (isWork_3_7[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает со среды до восресенья");
                }
                isWork_4_5[j] = do_office_4_5[j] == work_4_5;
                if (isWork_4_5[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с четверга до пятницы");
                }
                isWork_4_6[j] = do_office_4_6[j] == work_4_6;
                if (isWork_4_6[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с четверга до субботы");
                }
                isWork_4_7[j] = do_office_4_7[j] == work_4_7;
                if (isWork_4_7[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с четверга до восресенья");
                }
                isWork_5_6[j] = do_office_5_6[j] == work_5_6;
                if (isWork_5_6[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с пятницы до субботы");
                }
                isWork_5_7[j] = do_office_5_7[j] == work_5_7;
                if (isWork_5_7[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с пятницы до восресенья");
                }
                isWork_6_7[j] = do_office_6_7[j] == work_6_7;
                if (isWork_6_7[j])
                {
                    Console.WriteLine($"Офис номер {j + 1} работает с субботы до восресенья");
                }
            }
            Console.ReadKey();
        }
    }
}
