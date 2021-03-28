using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVOP1_1_2.Model
{
    internal class People
    {
        private static List<People> Peoples = new List<People>();
        internal string Name { get; private set; }
        internal string Surname { get; private set; }
        internal int Age { get; private set; }
        internal static double MinAge => Peoples.Min(x => x.Age);
        internal static double MaxAge => Peoples.Max(x => x.Age);
        internal static double AvgAge => Math.Round(Peoples.Average(x => x.Age), 2);
        internal static int Count => Peoples.Count;

        internal People(string name, string surname, int age )
        {
            Name = name;
            Surname = surname;
            Age = age;
            //TODO надо вынести добавление человека в массив в отдельную функцию согласно SR
            Peoples.Add(this);
        }

        //TODO Тут надо разобраться как работают геттеры, чтобы не писать как в Java
        internal static List<People> GetPeople()
        {
            return Peoples;
        }
    }
}
