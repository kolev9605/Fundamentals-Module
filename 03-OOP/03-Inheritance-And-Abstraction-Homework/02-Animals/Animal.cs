using _02_Animals;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} years old, gender: {this.Gender}";
        }
    }
}
