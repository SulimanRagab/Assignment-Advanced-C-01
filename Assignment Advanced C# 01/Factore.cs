using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class Factore : InterfaceTest
    {
        public static T CreateObject<T>() where T : new()// ال  new() هنا يعني انا بقول لل C# ان اي نوع بينات مكان  ال <T>  يكون عنده parameterless constructor فاضي مفهوش اي Parameters
        {
          return new T();
        }

        public void print()
        {
            Console.WriteLine(" print factoore");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
