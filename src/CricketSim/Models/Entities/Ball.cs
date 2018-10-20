using System;
using Models.ValueObjects;

namespace Models.Entities
{    
    public class Ball
    {
        private Line _line;

        private Length _length;

        public Ball (Line line, Length length) {
            _line = line;
            _length = length;
        }

        public override string ToString() {
            return "The ball is a " + _length + " " + _line + ".";
        }
    }
}