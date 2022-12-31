using ExerProdutosImportados.Entities;
using System.Diagnostics;
using System.Globalization;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace ExerProdutosImportados
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> produtos = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char eua = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (eua == 'i' || eua == 'I')
                {
                    Console.WriteLine("Customs Fee: ");
                    double custo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    produtos.Add(new ImportedProduct(nome, preco, custo));

                }
                else if (eua == 'u' || eua == 'U')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    produtos.Add(new UsedProduct(nome, preco, data));

                }
                else
                {

                    produtos.Add(new Product(nome, preco));
                }


               
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product prod in produtos)
            {
                Console.WriteLine(prod.Pricetag());
            }
        }
    }
}
