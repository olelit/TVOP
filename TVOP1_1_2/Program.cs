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

                if(People.Count > 0)
                {
                    Console.WriteLine(string.Format("{0} {1} {2}", "Имя", "Фамилия", "Возраст"));
                    foreach (var men in People.GetPeople())
                    {
                        Console.WriteLine(string.Format("{0} {1} {2}", men.Name, men.Surname, men.Age));
                    }
                    Console.WriteLine("\n");
   
                    Console.WriteLine("Минимальный возраст: " + People.MinAge);
                    Console.WriteLine("Максимальный возраст: " + People.MaxAge);
                    Console.WriteLine("Средний возраст: "+People.AvgAge);
                }

                
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
