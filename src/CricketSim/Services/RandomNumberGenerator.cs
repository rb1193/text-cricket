using System;

namespace Services
{
    public class RandomNumberGenerator
    {
        private Random _r;
        public RandomNumberGenerator() {
            _r = new Random();
        }

        public int Next(int min, int max)
        {
            return _r.Next(min, max);
        }
    }
}