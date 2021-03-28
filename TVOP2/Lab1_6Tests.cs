using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace TVOP2
{
    public class Lab1_6Tests
    {
        [Fact]
        public void Lab1_6CheckIfFileExist()
        {
            TVOP1_6.Program.Main(new string[] { "https://www.learningcontainer.com/sample-docx-file-for-testing", "D:\\test\\test.doc"});
            bool isFileExist = File.Exists("D:\\test\\test.doc");

            Assert.True(isFileExist);
        }
    }
}
