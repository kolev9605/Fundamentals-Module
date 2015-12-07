using System;
using System.Collections.Generic;
using _03_CompanyHierarchy.Interfaces;

namespace _03_CompanyHierarchy
{
    public class SalesEmployee : RegularEmployee, ISaleEmployee
    {
        private List<Sale> sales = new List<Sale>();

        public SalesEmployee(string firstName, string lastName, string id, decimal salary, Department department, List<Sale> sales) 
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get { return this.sales; }
            set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("List cannot be empty");
                }
                if (value == null)
                {
                    throw new ArgumentNullException("List cannot be null");
                }
                this.sales = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Sales set: [{string.Join(", ", this.Sales)}]";
        }
    }
}
