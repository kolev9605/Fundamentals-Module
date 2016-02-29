using System;
using System.Collections.Generic;

public class EnterNumbers
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());
            ReadNumbers(start, end);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid indexes");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid indexes");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid indexes");
        }

    }

    private static void ReadNumbers(int start, int end)
    {
        int currentMin = 1;
        var listOfNumbers = new List<int>();
        Console.WriteLine("Please enter 10 numbers, where every number must be bigger the the previous one, and it is in the range [{0}...{1}]", start, end);
        for (int i = 0; i < 10; i++)
        {
            int currentSelection = int.Parse(Console.ReadLine());
            while (true)
            {
                if (currentSelection <= currentMin)
                {
                    Console.Write("Please enter number bigger than {0}: ", currentMin);
                    currentSelection = int.Parse(Console.ReadLine());
                }
                else if (currentSelection < start || currentSelection > end)
                {
                    Console.Write("Please enter number in range [{0}...{1}]: ", start, end);
                    currentSelection = int.Parse(Console.ReadLine());
                }
                else { break; }
            }
            currentMin = currentSelection;
            listOfNumbers.Add(currentSelection);
        }
        Console.WriteLine("Your numbers are: [{0}].", string.Join(", ", listOfNumbers));
    }
}