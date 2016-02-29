using System;
using System.Collections.Generic;
using _03_CompanyHierarchy.Interfaces;

namespace _03_CompanyHierarchy
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees = new List<Employee>();

        public Manager(string firstName, string lastName, string id, List<Employee> employees) : base(firstName, lastName, id)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
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
                this.employees = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Sales set: [{string.Join(", ", this.Employees)}]";
        }
    }
}
