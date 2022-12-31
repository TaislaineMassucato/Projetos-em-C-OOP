using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProdutosImportados.Entities
{
    internal class ImportedProduct : Product
    {
        public double Customsfee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price,double customsfee) : base(name,price)
        {
            Customsfee = customsfee;
        }

        public double TotalPrice()
        {
            return Customsfee + Price;
        }
        public override string Pricetag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "(Customs fee: $ "
                + Customsfee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
