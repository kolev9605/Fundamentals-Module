using System;

class BiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        int num5 = int.Parse(Console.ReadLine());

        if (num1>num2)
        {
            if (num1>num3)
            {
                if (num1>num4)
                {
                    if (num1>num5)
                    {
                        Console.WriteLine(num1);
                    }
                    else
                    {
                        Console.WriteLine(num5);
                    }
                }
                else if (num4 > num5)
                {
                    Console.WriteLine(num4);
                }
                else
                {
                    Console.WriteLine(num5);
                }
            }
            else if (num3 > num4)
            {
                if (num3 > num5)
                {
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num5);
                }
            }
            else
            {
                Console.WriteLine(num4);
            }
        }
        else
        {
            Console.WriteLine(num2);
        }
    }
}
