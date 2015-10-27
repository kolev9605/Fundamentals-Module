using System;

class MinMaxSumAvg
{
    static void Main()
    {
        Console.Write("Please enter the amount of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        int minValue = Int32.MaxValue;
        int maxValue = Int32.MinValue;
        int sum = 0;
        double average;
        //Console.WriteLine("|{0,10}|{1,-10:D10}|{2,10:F2}|{3,-10:F3}|", hexValue, binaryValue, b, c);
        Console.WriteLine("Please enter {0} numbers: ", n);
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number<minValue)
            {
                minValue = number;
            }
            if (number>maxValue)
            {
                maxValue = number;
            }
            sum += number;
        }
        average = (double)sum / n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}",minValue,maxValue,sum,average);

    }
}

