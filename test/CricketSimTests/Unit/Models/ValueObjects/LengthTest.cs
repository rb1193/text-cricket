using System;
using Xunit;
using Exceptions;
using Models.ValueObjects;

namespace CricketSimTests
{
    public class Length_ToStringShould
    {        
        [Fact]
        public void ReturnShort_GivenValue1()
        {
            var length = new Length(1);
            Assert.True(length.ToString() == "short length");
        }

        [Fact]
        public void ReturnGood_GivenValue2()
        {
            var length = new Length(2);
            Assert.True(length.ToString() == "good length");
        }

        [Fact]
        public void ReturnFull_GivenValue3()
        {
            var length = new Length(3);
            Assert.True(length.ToString() == "full length");
        }

        [Fact]
        public void ThrowValueNotFoundException_GivenValue4()
        {
            var length = new Length(4);
            Assert.Throws<ValueNotFoundException>(() => length.ToString());
        }
    }
}
