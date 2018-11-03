using System;
using Services;
using Utils;
using Models.Entities;
using Models.ValueObjects;

namespace Factories
{
    public class BallFactory : IBallFactory
    {
        private IRandomNumberGenerator _r;

        private ITextUtils _t;

        public BallFactory(IRandomNumberGenerator r, ITextUtils t) {
            _r = r;
            _t = t;
        }

        public Ball MakeBall()
        {
            var length = new Length(_t, _r.Next(1, 4));
            var line = new Line(_t, _r.Next(1, 4));
            return new Ball(line, length);
        }
    }
}