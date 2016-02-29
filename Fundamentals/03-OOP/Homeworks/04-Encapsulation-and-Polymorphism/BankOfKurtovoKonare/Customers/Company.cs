namespace BankOfKurtovoKonare.Customers
{
    public class Company : Customer
    {
        public Company(string id, string phoneNumber, string companyName, string companyAddress) 
            : base(id, phoneNumber)
        {
            this.TypeCustomer = TypeCustomer.Company;
            this.CompanyName = companyName;
            this.CompanyAddress = companyAddress;
        }

        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
    }
}
