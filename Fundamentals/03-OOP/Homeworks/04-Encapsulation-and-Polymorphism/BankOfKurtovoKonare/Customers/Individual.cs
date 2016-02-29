using System.Runtime.CompilerServices;

namespace BankOfKurtovoKonare.Customers
{
    public class Individual : Customer
    {
        public Individual(string id, string phoneNumber, string firstName, string lastName) 
            : base(id, phoneNumber)
        {
            this.TypeCustomer = TypeCustomer.Individual;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
