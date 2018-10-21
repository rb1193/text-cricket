using System;
using Xunit;
using Exceptions;
using Models.ValueObjects;
using Utils;
using Moq;

namespace CricketSimTests
{
    public class Length_ToStringShould
    {        
        [Fact]
        public void ReturnShort_GivenValue1()
        {
            var _t = new Mock<ITextUtils>();
            var length = new Length(_t.Object, 1);
            Assert.True(length.ToString() == "short length");
        }

        [Fact]
        public void ReturnGood_GivenValue2()
        {
            var _t = new Mock<ITextUtils>();
            var length = new Length(_t.Object, 2);
            Assert.True(length.ToString() == "good length");
        }

        [Fact]
        public void ReturnFull_GivenValue3()
        {
            var _t = new Mock<ITextUtils>();
            var length = new Length(_t.Object, 3);
            Assert.True(length.ToString() == "full length");
        }

        [Fact]
        public void ThrowValueNotFoundException_GivenValue4()
        {
            var _t = new Mock<ITextUtils>();
            var length = new Length(_t.Object, 4);
            Assert.Throws<ValueNotFoundException>(() => length.ToString());
        }
    }
}
