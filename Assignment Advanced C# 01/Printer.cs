using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class Printer 
    {
        public static void printitem<T>(T item) where T : InterfaceTest
        {
          item.Print();
        }
  

    }
}
