using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(firstNum, secondNum));
    }

    static int GetMax(int firstNumber,int secondNumber)
    {
        return (Math.Max(firstNumber, secondNumber));
    }
}

