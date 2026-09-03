using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal interface IRepository<T>
    {
        public void Add(T item);
        public void Delete(int id);
        T GetById(int id);
        void printList();
    }
}
