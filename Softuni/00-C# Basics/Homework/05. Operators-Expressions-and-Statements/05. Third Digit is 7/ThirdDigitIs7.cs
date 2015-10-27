using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool thirdDigidIs7 = (number/100%10==7);
        Console.WriteLine(thirdDigidIs7);
    }
}
