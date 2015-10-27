using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int productOfOdds = 1;
        int productOfEvens = 1;

        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(input[i]);
            if ((i+1)%2==0)
            {
                productOfEvens *= number;
            }
            else
            {
                productOfOdds *= number;
            }
        }
        if (productOfOdds==productOfEvens)
        {
            Console.WriteLine("yes. product is {0}",productOfEvens);
        }
        else
        {
            Console.WriteLine("no. \nproduct of odds = {0} \nproduct of evens = {1}",productOfOdds,productOfEvens);
        }
    }
}

