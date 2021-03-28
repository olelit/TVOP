using System;

namespace TVOP1_1
{
    public class Program
    {
        public static string Output()
        {
            var rand = new Random();
            var helloWorld = "Hello World!";
            var andHiaGain = "Andhiagain!";
            var vosklSnak = new string('!', rand.Next(5, 50));
            return string.Format("{0}\n{1}\n{2}", helloWorld, andHiaGain, vosklSnak);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Output());
        }
    }
}
