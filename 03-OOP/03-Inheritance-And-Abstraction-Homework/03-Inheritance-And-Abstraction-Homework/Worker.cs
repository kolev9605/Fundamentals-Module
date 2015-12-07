using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance_And_Abstraction_Homework
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative;");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours must be positive number");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(decimal weekSalary, int workHoursPerDay)
        {
            return weekSalary * workHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - week salary: {2}, hours per day: {3}. => Salary per hour: {4}",
                this.FirstName,
                this.LastName,
                this.WeekSalary,
                this.WorkHoursPerDay,
                this.MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay));
        }
    }
}
