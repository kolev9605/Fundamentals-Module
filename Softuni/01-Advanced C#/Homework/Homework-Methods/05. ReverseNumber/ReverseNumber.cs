using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        decimal floatingNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Reverser(floatingNumber));
    }
    static decimal Reverser(decimal number)
    {
        int floatingDigitsCount = 0;
        List<int> numList = new List<int>();
        while (number % 1 != 0)
        {
            floatingDigitsCount++;
            number *= 10;
        }
        int numberAsInt = (int)number;
        int reversedNum = 0;
        int digitCount = 0;
        while (numberAsInt != 0)
        {
            reversedNum = reversedNum * 10 + (int)numberAsInt % 10;
            numberAsInt /= 10;
            digitCount++;
        }
        double result = (double)reversedNum/(Math.Pow(10,(double)digitCount-floatingDigitsCount));
        return (decimal)result;
    }
}

