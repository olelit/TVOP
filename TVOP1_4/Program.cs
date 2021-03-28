using System;
using System.Collections.Generic;
using System.IO;

namespace TVOP1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            lines.Add("<table cellspacing='0'>");
            for(int i = 255; i >= 0; i--)
            {
                string item = string.Format("<tr><td style='background-color:rgb({0},{0},{0});width:60px;height:10px;'></td</tr>", i);
                lines.Add(item);
            }
            lines.Add("</table>");
            File.WriteAllLines("main.html", lines);
        }
    }
}
