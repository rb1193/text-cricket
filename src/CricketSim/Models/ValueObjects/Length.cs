using System;
using System.Collections.Generic;
using Exceptions;
using Utils;

namespace Models.ValueObjects
{
    public class Length : Base
    {
        public Length(ITextUtils t, int value):base(t, value) {}

        public override string ToString() {
            switch (Value)
            {
                case 1:
                    return _t._T("ball.length.short");
                case 2:
                    return  _t._T("ball.length.good");
                case 3:
                    return _t._T("ball.length.full");
                default:
                    var errorValues = new List<string>();
                    errorValues.Add(Value.ToString());
                    string error = _t._TT("error.value_not_found", errorValues);
                    throw new ValueNotFoundException(error);
            }
        }
    }
}