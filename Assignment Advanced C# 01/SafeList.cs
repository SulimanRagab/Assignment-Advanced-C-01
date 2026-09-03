using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class SafeList<T>
    {
        private T[] safe;
        public SafeList(T[] item)
        {
            safe = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= safe.Length)
            {
                return default;
            }

            return safe[index];
        }

    }
}
