using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVOP1_1_2.Model
{
    class People
    {

        private static List<People> Peoples = new List<People>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public People(string name, string surname, int age )
        {
            Name = name;
            Surname = surname;
            Age = age;
            Peoples.Add(this);
        }

        internal static void Show()
        {
            if (Peoples.Count > 0)
                Console.WriteLine(string.Format("{0} {1} {2}", "Имя", "Фамилия", "Возраст"));

            foreach (var men in Peoples)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", men.Name, men.Surname, men.Age));
            }
        }

        internal static void ShowMinAge()
        {
            if(Peoples.Count > 0)
                Console.WriteLine("Минимальный возраст: "+Peoples.Min(x => x.Age));
        }

        internal static void ShowAvgAge()
        {
            if (Peoples.Count > 0)
                Console.WriteLine("Максимальный возраст: " + Peoples.Max(x => x.Age));
        }

        internal static void ShowMaxAge()
        {
            if (Peoples.Count > 0)
                Console.WriteLine("Средний возраст: " + Math.Round(Peoples.Average(x => x.Age), 2));
        }
    }
}
