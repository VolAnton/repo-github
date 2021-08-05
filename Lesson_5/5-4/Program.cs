using System;

namespace Lessons
{
    public class Person
    {
        public string Name { get; set; }
        public string Work { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Money { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(string name, string work, string email, string phone, int money, int age)
        {
            Name = name;
            Work = work;
            Email = email;
            Phone = phone;
            Money = money;
            Age = age;
        }
        public void PrintPerson()
        {
            Console.WriteLine($"ФИО: {Name}, должность: {Work}, email: {Email}, телефон: {Phone}, зарплата: {Money} руб., возраст: {Age} лет");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] personArray = new Person[5];
            personArray[0] = new Person("Волощук Антон Анатольевич", "Инженер", "11@tut.by", "297205627", 30000, 35);
            personArray[1] = new Person("Иванов Иван Николаевич", "Директор", "12@mail.ru", "999999", 300000, 41);
            personArray[2] = new Person("Семенов Семен Семенович", "гл. Инженер", "13@yandex.ru", "888888", 60000, 45);
            personArray[3] = new Person("Драг Дмитрий Иванович", "Мастер", "14@rambler.ru", "666666", 25000, 50);
            personArray[4] = new Person("Петров Петр Петрович", "Кладовщик", "15@gmail.com", "7777777", 25000, 30);
            for (int i = 0; i < personArray.Length; i++)
            {
                if (personArray[i].Age > 40)
                {
                    personArray[i].PrintPerson();
                }
            }
        }
    }
}
