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
        public order()
        {
            Console.WriteLine("create Ordeer");
        }
        public order(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //public override void rint()
        //{
        //    Console.WriteLine("print Order Up Class");
        //}

        public void Print()
        {
            Console.WriteLine("print order Interfase");
        }
    }
}
