using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment_Advanced_C__01
{
    internal class order : UpClass , InterfaceTest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public order()
        {
            Console.WriteLine("create Ordeer");
        }
        public order(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        //public override void rint()
        //{
        //    Console.WriteLine("print Order Up Class");
        //}
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
        public void Print()
        {
            Console.WriteLine("print order Interfase");
        }
    }
}
