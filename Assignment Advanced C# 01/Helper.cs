using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class Helper
    {
       public static void Swap<T>(T a ,T b)
       {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a: {a} , b: {b}");
       }
        public static T FindMax<T>(T a ,T b)
        where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
            { 
                return a;
            }
            else
            {
                return b;
            }
       }

    }
}
