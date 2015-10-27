using System;

class GCD
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int absoluteFirst = Math.Abs(firstNumber);
        int absoluteSecond = Math.Abs(secondNumber);
        while (absoluteFirst != 0 && absoluteSecond != 0)
        {

            if (absoluteFirst > absoluteSecond)
            {
                absoluteFirst %= absoluteSecond;
            }
            else
            {
                absoluteSecond %= absoluteFirst;
            }
        }
        Console.WriteLine(Math.Max(absoluteFirst,absoluteSecond));
    }
}

