using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Peshev";
        string lastName = "Peshevski";
        decimal accountBalance = 100.135m;
        string bankName = "Bank Name";
        string iban = "CH93 0076 2011 6238 5295 7";
        ulong creditCardNumber1 = 4532287518495165U;
        ulong creditCardNumber2 = 4024007172102823U;
        ulong creditcardNumber3 = 4916032317656864U;
        Console.WriteLine("{0} {1} {2}; \n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName, lastName, accountBalance, bankName,iban,creditCardNumber1, creditCardNumber2, creditcardNumber3);
    }
}

