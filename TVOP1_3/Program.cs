using System;

namespace TVOP1_3
{
    internal class Program
    {

        internal static int Square(int a, int b) => a * b;

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Введите длину: ");
            while (int.TryParse(Console.ReadLine(), out a) == false)
            {
                ErrorMessage();
            }
            Console.WriteLine("Введите ширину: ");
            while (int.TryParse(Console.ReadLine(), out b) == false)
            {
                ErrorMessage();
            }

            int s = Square(a, b);
            Console.WriteLine("Площадь прямоугольника: "+s.ToString());
        }

        static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введенные данные некорректы. Попробуйте еще раз");
            Console.ResetColor();
        }
    }
}
