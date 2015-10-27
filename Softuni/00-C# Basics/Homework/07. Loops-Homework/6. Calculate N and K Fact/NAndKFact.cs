using System;

class NAndKFact
{
    static void Main()
    {
        Console.WriteLine("Enter n and k (1 < k < n < 100).");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int nFact = 1;
        int kFact = 1;
        int sum = 0;
        while (true)
        {
            if (n > 0)
            {
                nFact *= n;
                n--;
            }
            else if (k > 0)
            {
                kFact *= k;
                k--;
            }
            else break;
        }
        sum = nFact / kFact;
        Console.WriteLine(sum);

    }
}
