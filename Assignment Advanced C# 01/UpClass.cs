using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class UpClass
    {
        public string value { get; set; }

        public virtual  void print()
        {
            Console.WriteLine("print class");
        }
    }
}
