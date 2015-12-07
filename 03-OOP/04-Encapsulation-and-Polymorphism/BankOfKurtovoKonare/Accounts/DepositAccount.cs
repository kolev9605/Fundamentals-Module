using System;
using BankOfKurtovoKonare.Customers;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance)
            : base(customer, balance)
        {
        }

        public void Withdraw(decimal value)
        {
            this.Balance -= value;
            Console.WriteLine("{0:F2}lv withdraw from the balance. Current balance: {1:F2}",
                value,
                this.Balance);
        }

        public override double CalculateInterest(int rate, int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(rate, months);
            }
        }

    }
}