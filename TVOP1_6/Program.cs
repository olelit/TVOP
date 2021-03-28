using System;
using System.Net;

namespace TVOP1_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string link = args[0];
            string path = args[1];

            using (var client = new WebClient())
            {
                client.DownloadFile(new Uri(link), path);
            }
        }
    }
}
