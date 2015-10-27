using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count=0;
        for (int i = 1; i <= n; i++)
        {
            count = i;
            for (int j = 1; j <= n; j++)
            {  
                Console.Write(count+" ");
                count++;
            }
            Console.WriteLine();
        }
    }
}

