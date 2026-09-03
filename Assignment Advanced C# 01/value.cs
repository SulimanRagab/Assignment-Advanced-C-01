using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class ValueType<T> where T : struct
    {
        public T value { get; set; }
        public ValueType(T Value)
        {
            value = Value;
            
        }
    }
}
