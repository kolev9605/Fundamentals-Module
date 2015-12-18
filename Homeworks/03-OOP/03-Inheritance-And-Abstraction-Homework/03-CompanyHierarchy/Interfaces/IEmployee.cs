namespace _03_CompanyHierarchy.Interfaces
{
    interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}
