using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01.Q20CacheStorge
{
    internal class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime Expiration { get; set; }
    }
}
