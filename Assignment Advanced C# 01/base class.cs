using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class baseclass
    {
        public static void classbasec<T>(T Class)
         where T : UpClass
        {
            Class.print();
            Console.WriteLine(Class.value);
        }

        public static void Multetype<T>(T item) where T : UpClass , InterfaceTest , new()
        {
            item.print();
            item.Print();
        }
    }
}
