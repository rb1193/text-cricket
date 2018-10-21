using System;
using Exceptions;
using Utils;

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
                    return TextUtils._T("ball.line.outsideOff");
                case 2:
                    return  TextUtils._T("ball.line.off");
                case 3:
                    return TextUtils._T("ball.line.leg");
                default:
                    throw new ValueNotFoundException("The value " + Value + " does not" +
                        " have a corresponding line");
            }
        }
    }
}