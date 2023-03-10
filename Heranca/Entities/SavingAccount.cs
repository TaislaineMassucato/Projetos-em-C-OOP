using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
      class SavingAccount:Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance,double interestRate):base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdaw(double amount)
        {
            base.Withdaw(amount);

            Balance -= 2.0;
        }
    }
}
