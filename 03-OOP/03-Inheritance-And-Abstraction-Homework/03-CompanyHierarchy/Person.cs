using _03_CompanyHierarchy.Interfaces;

namespace _03_CompanyHierarchy
{
    public class Person : IPerson
    {
        public Person(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return $"{this.Id}: {this.FirstName} {this.LastName}";
        }
    }
}
