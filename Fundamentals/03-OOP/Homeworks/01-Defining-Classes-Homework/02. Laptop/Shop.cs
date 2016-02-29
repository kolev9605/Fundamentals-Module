using System;

public class Shop
{
    public static void Main()
    {
        Laptop firstLaptop = new Laptop("toshiba", 123.23m);
        Laptop secondLaptop = new Laptop("W500", 420.420m, "Lenovo", "i10 10ghz", "69 GB", "GTX 420", "1TB", "Mat", new Battery("123 mha", 24));
        Console.WriteLine(firstLaptop);
        Console.WriteLine();
        Console.WriteLine(secondLaptop);
    }
    

}