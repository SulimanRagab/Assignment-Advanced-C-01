using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced_C__01
{
    internal class OrderRepository : IRepository<order>
    {
        List<order> Order = new();
        public void Add(order item) => Order.Add(item);

         public void printList()
        {
            foreach (var item in Order)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void Delete(int id)
        {
            var order = GetById(id);
            Order.Remove(order);
        }   
        public order GetById(int id) => Order.Find(objectt => objectt.Id == id);
    }
}
