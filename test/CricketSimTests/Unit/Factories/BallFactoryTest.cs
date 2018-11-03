using System;
using Xunit;
using Factories;
using Models.Entities;
using Services;
using Utils;
using Moq;

namespace CricketSimTests
{
    public class BallFactory_MakeBallShould
    {
        private readonly BallFactory _factory;

        public BallFactory_MakeBallShould()
        {
            var t = new Mock<ITextUtils>();
            _factory = new BallFactory(new RandomNumberGenerator(), t.Object);
        }
        
        [Fact]
        public void ReturnBall()
        {
            var ball = _factory.MakeBall();
            Assert.IsType<Ball>(ball);
        }
    }
}
