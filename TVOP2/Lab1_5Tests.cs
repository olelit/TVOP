using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace TVOP2
{
    public class Lab1_5Tests
    {
        [Fact]
        public void Lab1_5CheckReturnIsArray()
        {
            string[] result = TVOP1_5.Program.FindedFiles("D:\\test", "txt" );

            Assert.IsType<string[]>(result);
        }
    }
}
