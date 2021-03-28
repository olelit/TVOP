using System;
using TVOP1_1_2.Model;

namespace TVOP1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                People.Show();
                Console.WriteLine("\n");
                People.ShowMinAge();
                People.ShowMaxAge();
                People.ShowAvgAge();
                Console.WriteLine("\n");
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.Write("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());

                new People(name, surname, age);
            }
        }
    }
}
