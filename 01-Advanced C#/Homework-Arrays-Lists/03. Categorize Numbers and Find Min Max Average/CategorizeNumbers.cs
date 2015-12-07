using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }
        List<double> roundSet = new List<double>();
        List<double> floatSet = new List<double>();

        int intSum = 0;
        double intAverage;
        int intMax = int.MinValue;
        int intMin = int.MaxValue;

        double doubleSum = 0;
        double doubleAverage;
        double doubleMax = double.MinValue;
        double doubleMin = double.MaxValue;

        foreach (var item in arr)
        {
            if (item %1==0)
            {
                roundSet.Add(item);
            }
            else
            {
                floatSet.Add(item);
            }
        }
        intMin = (int)roundSet.Min();
        intMax = (int)roundSet.Max();
        intAverage = (int)roundSet.Average();
        intSum = (int)roundSet.Sum();

        doubleMin = floatSet.Min();
        doubleMax = floatSet.Max();
        doubleAverage = floatSet.Average();
        doubleSum = floatSet.Sum();
        Console.WriteLine("Round set max: {0}; Round set min: {1}; Round set sum: {2}; Round set avg: {3:F2}", intMax, intMin, intSum, intAverage);
        Console.WriteLine("Float set max: {0}; Float set min: {1}; Float set sum: {2}; Float set avg: {3:F2}", doubleMax, doubleMin, doubleSum, doubleAverage);
    }
}

