using System;

namespace TVOP1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var helloWorld = "Hello World!";
            var andHiaGain = "Andhiagain!";
            var vosklSnak = new String('!', rand.Next(5, 50));
            Console.WriteLine(string.Format("{0}\n{1}\n{2}", helloWorld, andHiaGain, vosklSnak));
        }
    }
}
