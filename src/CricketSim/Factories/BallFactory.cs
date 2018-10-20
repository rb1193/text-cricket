using System;
using Services;
using Models.Entities;
using Models.ValueObjects;

namespace Factories
{
    public class BallFactory
    {
        private RandomNumberGenerator _r;

        public BallFactory(RandomNumberGenerator r) {
            _r = r;
        }

        public Ball GetBall()
        {
            var length = new Length(_r.Next(1, 4));
            var line = new Line(_r.Next(1, 4));
            return new Ball(line, length);
        }
    }
}