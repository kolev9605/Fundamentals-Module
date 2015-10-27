using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the amount of numbers you will enter: ");
        int numbersToBeEntered = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersToBeEntered];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Element {0}: ",i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        Console.WriteLine("Sorted Array:");
        foreach (var step in numbers)
        {
            Console.Write(step+" ");
        }
    }
}

