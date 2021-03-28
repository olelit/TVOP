using System;
using System.Collections.Generic;
using System.Text;
using TVOP1_1_2.Model;
using Xunit;

namespace TVOP2
{
    public class Lab1_2Tests
    {
        [Fact]
        public void Lab1_2ViewPeopleArray()
        {
            var people = new People("x", "y", 1);
            var people1 = new People("x1", "y2", 2);
            var people2 = new People("x3", "y3", 3);
            var people3 = new People("x4", "y4", 4);

            List<People> test = new List<People>();
            test.Add(people);
            test.Add(people1);
            test.Add(people2);
            test.Add(people3);

            Assert.Equal(test, People.GetPeople());
        }

        [Fact]
        public void Lab1_2ViewMinAge()
        {
            var people = new People("x", "y", 1);
            var people1 = new People("x1", "y2", 2);
            var people2 = new People("x3", "y3", 3);
            var people3 = new People("x4", "y4", 4);

            Assert.Equal(1, People.MinAge);
        }

        [Fact]
        public void Lab1_2ViewMaxAge()
        {
            var people = new People("x", "y", 1);
            var people1 = new People("x1", "y2", 2);
            var people2 = new People("x3", "y3", 3);
            var people3 = new People("x4", "y4", 4);

            Assert.Equal(4, People.MaxAge);
        }

        [Fact]
        public void Lab1_2ViewAvgAge()
        {
            var people = new People("x", "y", 1);
            var people1 = new People("x1", "y2", 2);
            var people2 = new People("x3", "y3", 3);
            var people3 = new People("x4", "y4", 4);

            Assert.Equal(2.5, People.AvgAge);
        }
    }
}
