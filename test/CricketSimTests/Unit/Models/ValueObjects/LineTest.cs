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
        public void ReturnAString_GivenValueBetweenOneAndThree()
        {
            var _t = new Mock<ITextUtils>();
            _t.Setup(TextUtils => TextUtils._T("ball.line.outsideOff")).Returns("foo");
            _t.Setup(TextUtils => TextUtils._T("ball.line.off")).Returns("bar");
            _t.Setup(TextUtils => TextUtils._T("ball.line.leg")).Returns("baz");
            var line = new Line(_t.Object, 1);
            Assert.True(line.ToString() == "foo");
            var line2 = new Line(_t.Object, 2);
            Assert.True(line2.ToString() == "bar");
            var line3 = new Line(_t.Object, 3);
            Assert.True(line3.ToString() == "baz");
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
