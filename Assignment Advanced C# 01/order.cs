using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment_Advanced_C__01
{
    internal class order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public order(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
