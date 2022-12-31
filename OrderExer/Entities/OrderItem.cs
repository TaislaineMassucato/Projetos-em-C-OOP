using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExer.Entities
{
    internal class OrderItem
    {
        public int Quantity{ get; set; }
        public double Price { get; set; }
        public Products Product { get; set; }


        public OrderItem()
        {

        }

        public OrderItem(int qtd, double preco, Products produto)
        {
            Quantity = qtd;
            Price = preco;
            Product = produto;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
