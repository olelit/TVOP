using System;
using System.IO;
using System.Linq;

namespace TVOP1_5
{
    internal class Program
    {

        internal static string[] FindedFiles(string folder, string extension)
        {
            string[] files = new DirectoryInfo(folder).GetFiles("*." + extension, SearchOption.AllDirectories)
                    .Select(f => f.FullName).ToArray();

            return files;
        }

        internal static void Main(string[] args)
        {
            string folder = args[0];
            string extension = args[1];

            string[] files = FindedFiles(folder, extension);

            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Поиск окончен");
        }
    }
}
