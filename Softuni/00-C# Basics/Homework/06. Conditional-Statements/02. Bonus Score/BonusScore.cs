using System;

class BonusScore
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        if (input >= 1 && input <= 3)
        {
            input *= 10;
            Console.WriteLine(input);
        }
        else if (input >= 4 && input <= 6)
        {
            input *= 100;
            Console.WriteLine(input);
        }
        else if (input >= 7 && input <= 9)
        {
            input *= 1000;
            Console.WriteLine(input);
        }
        else if (input == 0 || input > 9)
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

