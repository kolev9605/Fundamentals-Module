using System;

class ExchangeIfGreater
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber<secondNumber)
        {
            Console.WriteLine(firstNumber+" "+secondNumber);
        }
        else 
        {
            Console.WriteLine(secondNumber+" "+firstNumber);
        }
    }
}

