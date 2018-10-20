using System;
using Xunit;
using Factories;
using Models.Entities;

namespace CricketSimTests
{
    public class BallFactory_GetBallShould
    {
        private readonly BallFactory _factory;

        public BallFactory_GetBallShould()
        {
            _factory = new BallFactory(new Services.RandomNumberGenerator());
        }
        
        [Fact]
        public void ReturnBall()
        {
            var ball = _factory.GetBall();
            Assert.IsType<Ball>(ball);
        }
    }
}
