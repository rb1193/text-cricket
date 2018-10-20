using System;
using Exceptions;

namespace Models.ValueObjects
{
    public struct Line
    {
        public int Value { get; private set; }

        public Line(int i) {
            Value = i;
        }

        public override string ToString() {
            switch (Value)
            {
                case 1:
                    return "outside off stump";
                case 2:
                    return "on off stump";
                case 3:
                    return "on leg stump";
                default:
                    throw new ValueNotFoundException("The value " + Value + " does not" +
                        " have a corresponding line");
            }
        }
    }
}