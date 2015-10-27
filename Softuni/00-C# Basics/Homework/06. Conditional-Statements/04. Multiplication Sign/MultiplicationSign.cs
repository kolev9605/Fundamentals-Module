using System;

class MultiplicationSign
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine(0);
        }
        else if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) ||
            (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) ||
            (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) ||
            (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0))
        {
            Console.WriteLine("+");
        }
        else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
        {
            Console.WriteLine("-");
        }
    }
}

