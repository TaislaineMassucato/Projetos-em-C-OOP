using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProdutosImportados.Entities
{
    internal class UsedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        } 

        public UsedProduct(string name, double price,DateTime data) : base (name, price)
        {
            ManufactureDate= data;
        }

        public override string Pricetag()
        {
            return base.Pricetag()
                + " "
                + "(Manufacture date: )"
                + ManufactureDate;

        }
    }
}
