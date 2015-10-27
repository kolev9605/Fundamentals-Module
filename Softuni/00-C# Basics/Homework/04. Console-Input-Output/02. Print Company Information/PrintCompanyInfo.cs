using System;

class PrintCompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string website = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} (age: {6}, tel. {7})",companyName, companyAddress, phoneNumber, faxNumber, website,managerFirstName,managerLastName,managerPhone);


    }
}