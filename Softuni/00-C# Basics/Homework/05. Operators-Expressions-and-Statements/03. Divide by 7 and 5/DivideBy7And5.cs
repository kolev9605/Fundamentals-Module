using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool divideChecker =((number%7==0)&&(number%5==0)&&(number!=0));
        Console.WriteLine(divideChecker);
    }
}

