using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjExcessao.Entities.Excessao;

namespace ProjExcessao.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account(int numeroconta, string nome, double saldoinicial, double limitesaque)
        {
            Number = numeroconta;
            Holder = nome;
            Balance = saldoinicial;
            WithdrawLimit = limitesaque;
        }

        public void Deposit(double amount)
        {
            Balance= Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance <= 0 || amount > WithdrawLimit)
            {
                throw new ExceAccount("Verifique ( Sem money) ou (Limite incompativel com o saque)");
            }
            else
            {
                Balance = Balance - amount;
            }
        }
    }
}
