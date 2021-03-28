using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TVOP2
{
    public class Lab1_3Tests
    {
        [Fact]
        public void Lab1_3ShowSquare()
        {
            int square = TVOP1_3.Program.Square(1, 3);
            Assert.Equal(3, square);
        }
    }
}
