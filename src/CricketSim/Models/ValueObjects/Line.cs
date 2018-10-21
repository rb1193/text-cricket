using System;
using Exceptions;
using Utils;

namespace Models.ValueObjects
{
    public class Line : Base
    {
        public Line(ITextUtils t, int i):base(t, i) {}

        public override string ToString() {
            switch (Value)
            {
                case 1:
                    return _t._T("ball.line.outsideOff");
                case 2:
                    return  _t._T("ball.line.off");
                case 3:
                    return _t._T("ball.line.leg");
                default:
                    string error = _t._T("error.value_not_found", new object[Value]);
                    throw new ValueNotFoundException(error);
            }
        }
    }
}