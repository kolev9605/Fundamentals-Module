using System;

class DataTypes
{
    static void Main()
    {
        int intInput;
        double doubleInput;
        string stringInput;
        Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string");
        int inputPick = int.Parse(Console.ReadLine());
        switch (inputPick)
        {
            case 1:
                Console.Write("Please enter int: ");
                intInput = int.Parse(Console.ReadLine());
                intInput += 1;
                Console.WriteLine(intInput);
                break;
            case 2:
                Console.Write("Please enter double: ");
                doubleInput = double.Parse(Console.ReadLine());
                doubleInput += 1;
                Console.WriteLine(doubleInput);
                break;
            case 3:
                Console.Write("Please enter string: ");
                stringInput = Console.ReadLine();
                stringInput += "*";
                Console.WriteLine(stringInput);
                break;
            default:
                Console.WriteLine("Invalid input ");
                break;
        }
    }
}

