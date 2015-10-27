using System;

class Sort3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a>b)
        {
            if (a>c)
            {
                Console.WriteLine(a);
                if (b>c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
        else if (b>c)
        {
            Console.WriteLine(b);
            if (a>c)
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }

        else if (c>b)
        {
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}

