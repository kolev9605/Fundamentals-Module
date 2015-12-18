using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigit(number));
    }
    static string GetLastDigit(int number)
    {
        switch (number % 10)
        {
            case 0:
                {
                    return "zero";
                }
            case 1:
                {
                    return "one";
                }
            case 2:
                {
                    return "two";
                }
            case 3:
                {
                    return "three";
                }
            case 4:
                {
                    return "four";
                }
            case 5:
                {
                    return "five";
                }
            case 6:
                {
                    return "six";
                }
            case 7:
                {
                    return "seven";
                }
            case 8:
                {
                    return "eight";
                }
            case 9:
                {
                    return "nine";
                }

            default:
                return "NaN";
        }
    }
}

