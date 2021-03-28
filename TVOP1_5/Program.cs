using System;
using System.IO;
using System.Linq;

namespace TVOP1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = args[0];
            string extension = args[1];

            string[] files = new DirectoryInfo(folder).GetFiles("*."+extension, SearchOption.AllDirectories)
                                .Select(f => f.FullName).ToArray();
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Поиск окончен");
        }
    }
}
