using System;
using System.Numerics;
class CalculateSomethingElse
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: (1 < k < n < 100): ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1, kFact = 1, nKFact=1,nMinusK = n - k;

        BigInteger result;

        while (true)
        {
            if (n > 1)
            {
                nFact *= n;
                n--;
            }
            else if (k > 1)
            {
                kFact *= k;
                k--;
            }
            else if (nMinusK>1)
            {
                nKFact *= nMinusK;
                nMinusK--;
            }
            else break;
        }
        result = nFact / (kFact * nKFact);
        Console.WriteLine(result);
    }
}