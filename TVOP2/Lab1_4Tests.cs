using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace TVOP2
{
    public class Lab1_4Tests
    {
        [Fact]
        public void Lab1_4CheckIfFileCreated()
        {
            TVOP1_4.Program.Main(new string[0]);
            bool isFileExist = File.Exists("main.html");

            Assert.True(isFileExist);
        }
    }
}
