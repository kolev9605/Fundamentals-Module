using System;
using BankOfKurtovoKonare.Customers;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    public abstract class Account : IDeposit
    {
        protected Account(Customer customer, decimal balance)
        {
            this.Customer = customer;
            this.Balance = balance;
        }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public int InterestRate { get; set; }

        public virtual void Deposit(decimal value)
        {
            this.Balance += value;
            Console.WriteLine("{0:F2}lv deposited to the balance. Current balance: {1:F2}",
                value,
                this.Balance);
        }

        public virtual double CalculateInterest(int rate, int months)
        {
            //A = money * (1 + interest rate * months) 
            return (double)this.Balance * (1 + rate * months);
        }
    }
}