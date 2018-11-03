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
        public void ReturnAString_GivenValueBetweenOneAndThree()
        {
            var _t = new Mock<ITextUtils>();
            _t.Setup(TextUtils => TextUtils._T("ball.length.short")).Returns("foo");
            _t.Setup(TextUtils => TextUtils._T("ball.length.good")).Returns("bar");
            _t.Setup(TextUtils => TextUtils._T("ball.length.full")).Returns("baz");
            var length = new Length(_t.Object, 1);
            Assert.True(length.ToString() == "foo");
            var length2 = new Length(_t.Object, 2);
            Assert.True(length2.ToString() == "bar");
            var length3 = new Length(_t.Object, 3);
            Assert.True(length3.ToString() == "baz");
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
