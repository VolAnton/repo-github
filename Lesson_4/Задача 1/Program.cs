using System;

namespace Lessons
{
    class Program
    {

        static void Main(string[] args)
        {
            int users = GetUsersCount();
            GetInfo(users);
        }
        static void GetFullName(string name, string lastName, string patronymic)

        {
            Console.WriteLine($"{lastName} {name} {patronymic}");
        }

        static int GetUsersCount()
        {
            int userCount = 0;
            do
            {
                Console.WriteLine("Укажите количество человек (от 1 до 5)");
                userCount = Convert.ToInt32(Console.ReadLine());
            }
            while (userCount < 1 || userCount > 5);
            Console.WriteLine($"Вы указали {userCount} человек(а)");
            return userCount;
        }
        static void GetInfo(int number)
        {
            string[,] usersData = new string[3, 3];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Заполняем данные {i + 1} человека");
                Console.WriteLine("Введите имя");
                usersData[i, 0] = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                usersData[i, 1] = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                usersData[i, 2] = Console.ReadLine();
            }
            for (int j = 0; j < number; j++)
            {
                Console.WriteLine($"Выводим данные {j + 1} человека");
                GetFullName(usersData[j, 0], usersData[j, 1], usersData[j, 2]);
            }
        }
    }
}
