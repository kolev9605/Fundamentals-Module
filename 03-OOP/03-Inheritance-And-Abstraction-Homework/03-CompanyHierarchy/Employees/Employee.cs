using _03_CompanyHierarchy.Interfaces;

namespace _03_CompanyHierarchy
{
    public class Employee : Person, IEmployee //should it be abstract???
    {
        public Employee(string firstName, string lastName, string id, decimal salary, Department department) : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}, Salary: {this.Salary}, Department: {this.Department}");
        }
    }
}
