namespace _03_CompanyHierarchy
{
    public class RegularEmployee : Employee //abstract??
    {
        public RegularEmployee(string firstName, string lastName, string id, decimal salary, Department department) : base(firstName, lastName, id, salary, department)
        {
        }
    }
}
