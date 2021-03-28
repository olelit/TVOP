using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TVOP2
{
    public class Lab1_1Tests
    {
        [Fact]
        public void Lab1ViewMessage()
        {
            string result = TVOP1_1.Program.Output();
            Assert.Contains("Hello World!\nAndhiagain!\n!!!!!", result);
        }
    }
}
