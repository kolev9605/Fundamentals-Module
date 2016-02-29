using System;
using BankOfKurtovoKonare.Customers;

namespace BankOfKurtovoKonare.Accounts
{
    class LoanAccount : Account
    {

        public LoanAccount(Customer customer, decimal balance)
            : base(customer, balance)
        {
        }

        public override double CalculateInterest(int rate, int months)
        {
            if (this.Customer.TypeCustomer == TypeCustomer.Individual)
            {
                if (months > 3)
                {
                    return base.CalculateInterest(rate, months);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 2)
                {
                    return base.CalculateInterest(rate, months);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}