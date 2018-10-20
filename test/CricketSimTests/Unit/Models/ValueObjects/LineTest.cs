using System;
using Xunit;
using Exceptions;
using Models.ValueObjects;

namespace CricketSimTests
{
    public class Line_ToStringShould
    {        
        [Fact]
        public void ReturnShort_GivenValue1()
        {
            var line = new Line(1);
            Assert.True(line.ToString() == "outside off stump");
        }

        [Fact]
        public void ReturnGood_GivenValue2()
        {
            var line = new Line(2);
            Assert.True(line.ToString() == "on off stump");
        }

        [Fact]
        public void ReturnFull_GivenValue3()
        {
            var line = new Line(3);
            Assert.True(line.ToString() == "on leg stump");
        }

        [Fact]
        public void ThrowValueNotFoundException_GivenValue4()
        {
            var line = new Line(4);
            Assert.Throws<ValueNotFoundException>(() => line.ToString());
        }
    }
}
