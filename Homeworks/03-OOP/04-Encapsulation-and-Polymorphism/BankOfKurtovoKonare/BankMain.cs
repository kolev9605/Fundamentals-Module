using System;
using BankOfKurtovoKonare.Accounts;
using BankOfKurtovoKonare.Customers;

namespace BankOfKurtovoKonare
{
    public class BankMain
    {
        static void Main()
        {
            Customer firstCustomer = new Individual("111", "1111111111", "Pesho", "Petrov");
            LoanAccount loanAccount = new LoanAccount(firstCustomer, 500m);
            Console.WriteLine(loanAccount.CalculateInterest(50, 12));
        }
    }
}
