using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
     class SavingsAccount : Account
    {
        public double InterestRate { get; protected set; }

        public void Account()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double loanLimit, double interestRate)
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void withDraw(double amount)
        {
            base.withDraw(amount);
            Balance -= 2.0;

        }

    }
}
