using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExer.Entities
{
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products()
        {

        }
        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
