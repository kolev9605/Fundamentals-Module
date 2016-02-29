using System;
using BankOfKurtovoKonare.Customers;

namespace BankOfKurtovoKonare.Accounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance)
            : base(customer, balance)
        {
        }

        public override double CalculateInterest(int rate, int months)
        {
            //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.

            if (this.Customer.TypeCustomer == TypeCustomer.Company)
            {
                if (months > 12)
                {
                    return base.CalculateInterest(rate, months);
                }
                else
                {
                    return (base.CalculateInterest(rate, months)) / 2;
                }
            }
            else
            {
                if (months > 6)
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