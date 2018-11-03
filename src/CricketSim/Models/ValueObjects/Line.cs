using System;
using System.Collections.Generic;
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
                    var errorValues = new List<string>();
                    errorValues.Add(Value.ToString());
                    string error = _t._TT("error.value_not_found", errorValues);
                    throw new ValueNotFoundException(error);
            }
        }
    }
}