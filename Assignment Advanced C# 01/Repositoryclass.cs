using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class Repositoryclass<T> where T : class
    {
        public T value {  get; set; }

        public Repositoryclass(T Value)
        {
          value = Value;
        }
    }
}
