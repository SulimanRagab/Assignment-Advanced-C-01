using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class UpClass<T>
    {
        public string value { get; set; }

        public virtual void print()
        {
            Console.WriteLine("print class");
        }
        public void Add(T item)
        {
            Console.WriteLine(item);
        }
    }
}
