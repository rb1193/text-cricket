using System;
using Xunit;
using Exceptions;
using Models.ValueObjects;
using Utils;
using Moq;

namespace CricketSimTests
{
    public class Line_ToStringShould
    {        
        [Fact]
        public void ReturnOutsideOffStump_GivenValue1()
        {
            var _t = new Mock<ITextUtils>();
            var line = new Line(_t.Object, 1);
            Assert.True(line.ToString() == "outside off stump");
        }

        [Fact]
        public void ReturnOnOffStump_GivenValue2()
        {
            var _t = new Mock<ITextUtils>();
            var line = new Line(_t.Object, 2);
            Assert.True(line.ToString() == "on off stump");
        }

        [Fact]
        public void ReturnOnLegStump_GivenValue3()
        {
            var _t = new Mock<ITextUtils>();
            var line = new Line(_t.Object, 3);
            Assert.True(line.ToString() == "on leg stump");
        }

        [Fact]
        public void ThrowValueNotFoundException_GivenValue4()
        {
            var _t = new Mock<ITextUtils>();
            var line = new Line(_t.Object, 4);
            Assert.Throws<ValueNotFoundException>(() => line.ToString());
        }
    }
}
