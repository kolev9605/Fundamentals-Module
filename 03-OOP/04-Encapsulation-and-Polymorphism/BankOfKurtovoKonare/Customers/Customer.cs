using System.Security.AccessControl;

namespace BankOfKurtovoKonare.Customers
{
    public abstract class Customer
    {
        protected Customer(string id, string phoneNumber)
        {
            Id = id;
            PhoneNumber = phoneNumber;
        }

        public string Id { get; set; }
        public TypeCustomer TypeCustomer { get; protected set; }
        public string PhoneNumber { get; set; }
    }
}
