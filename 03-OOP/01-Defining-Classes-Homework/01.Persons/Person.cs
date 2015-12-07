using System;

public class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Please enter valid name");
            }
            this.name = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age must be in range [1-100]");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                this.email = "(not set)";
            }
            else if (!value.Contains("@"))
            {
                throw new ArgumentException("The email must contain @");
            }
            else
            {
                this.email = value;
            }
        }
    }

    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }

    public Person(string name, int age)
        : this(name, age, "")
    {
    }
    public override string ToString()
    {
        return String.Format("{0} who is {1} years old, has email: {2}.",
            Name, Age, Email);
    }
}


class PersonTest
{
    public static void Main()
    {
        Person kiro = new Person("Kiro", 12, "kiro@kiro.kiro");
        Person asen = new Person("Gosho", 12);

        Console.WriteLine(kiro);
        Console.WriteLine(asen);
    }
}