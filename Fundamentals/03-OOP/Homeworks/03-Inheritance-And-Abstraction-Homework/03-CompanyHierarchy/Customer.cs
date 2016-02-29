namespace _03_CompanyHierarchy
{
    class Customer: Person, ICustomer
    {
        //Customer – holds the net purchase amount (total amount of money the customer has spent).

        public Customer(string firstName, string lastName, string id, decimal totalMoneySpent) : base(firstName, lastName, id)
        {
            this.TotalMoneySpent = totalMoneySpent;
        }

        public decimal TotalMoneySpent { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, total money spent: {this.TotalMoneySpent}";
        }
    }
}
