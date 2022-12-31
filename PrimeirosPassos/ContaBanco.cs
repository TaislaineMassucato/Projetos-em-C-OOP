using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ContaBanco
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBanco(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBanco(int numero, string titular, double depositoinicial) : this(numero, titular)
        {
            Deposito(depositoinicial);
        }

         public void Deposito(double quantia )
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -=  5.0;
        }

        public override string ToString()
        {
            return "Conta"
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

