using ProjExcessao.Entities;
using ProjExcessao.Entities.Excessao;
using System.Globalization;

namespace ProjetoExcessao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int conta = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string nomee = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double inicio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account infos = new Account(conta, nomee, inicio, limite);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                infos.Withdraw(valor);

                Console.WriteLine("New balance: " + infos.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
            catch (ExceAccount ex)
            {
                Console.WriteLine("Erro de retirada: " + ex.Message);
            }
        }
    }
}
