using System;
using System.Collections.Generic;
using Exceptions;
using Utils;

namespace Models.ValueObjects
{
    public class Length : Base
    {
        public Length(ITextUtils t, int i):base(t, i) {}

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
                    string error = _t._T("error.value_not_found", new object[Value]);
                    throw new ValueNotFoundException(error);
            }
        }
    }
}