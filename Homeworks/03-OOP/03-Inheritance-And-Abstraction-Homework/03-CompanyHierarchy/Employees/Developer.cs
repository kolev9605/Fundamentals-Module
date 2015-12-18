using System;
using System.Collections.Generic;

namespace _03_CompanyHierarchy.Employees
{
    class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects = new List<Project>();

        public Developer(string firstName, string lastName, string id, decimal salary, Department department, List<Project> projects ) 
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return projects; }
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
                projects = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Sales set: [{string.Join(", ", this.Projects)}]";
        }
    }
}
