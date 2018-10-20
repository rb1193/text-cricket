using System;
using Exceptions;

namespace Models.ValueObjects
{
    public struct Length
    {
        public int Value { get; private set; }

        public Length(int i) {
            Value = i;
        }

        public override string ToString() {
            switch (Value)
            {
                case 1:
                    return "short length";
                case 2:
                    return "good length";
                case 3:
                    return "full length";
                default:
                    throw new ValueNotFoundException("The value " + Value + " does not" +
                        " have a corresponding length");
            }
        }
    }
}