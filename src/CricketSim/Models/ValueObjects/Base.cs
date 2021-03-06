using System;
using Exceptions;
using Utils;

namespace Models.ValueObjects
{
    public abstract class Base
    {
        public int Value { get; private set; }

        protected ITextUtils _t;

        public Base (ITextUtils t, int value)
        {
            _t = t;
            Value = value;
        }
    }
}