using System;
using System.Collections.Generic;

class NumberCalculations
{
    static void Main()
    {
        int[] intArr = { 3, 3, 62, 34, 12, 6 };
        Console.WriteLine(SumOfArray(intArr));
        Console.WriteLine(MinOfArray(intArr));
        Console.WriteLine(MaxOfArray(intArr));
        Console.WriteLine(AvgOfAray(intArr));
        Console.WriteLine(ProductOfArray(intArr));
        Console.WriteLine();
        double[] doubleArr = { 2.32, 12.64, 1.2, 64.3421, 2.123123 };
        Console.WriteLine(SumOfArray(doubleArr));
        Console.WriteLine(MinOfArray(doubleArr));
        Console.WriteLine(MaxOfArray(doubleArr));
        Console.WriteLine(AvgOfAray(doubleArr));
        Console.WriteLine(ProductOfArray(doubleArr));
        Console.WriteLine();
        decimal[] decimalArr = { 64.1m, 74.5m, 6.2341m, 123.3617m };
        Console.WriteLine(SumOfArray(decimalArr));
        Console.WriteLine(MinOfArray(decimalArr));
        Console.WriteLine(MaxOfArray(decimalArr));
        Console.WriteLine(AvgOfAray(decimalArr));
        Console.WriteLine(ProductOfArray(decimalArr));
        Console.WriteLine();
    }

    static int SumOfArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static double SumOfArray(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static decimal SumOfArray(decimal[] array)
    {
        decimal sum = 0m;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static int MinOfArray(int[] array)
    {
        int currentMin = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentMin > array[i])
            {
                currentMin = array[i];
            }
        }
        return currentMin;
    }
    static double MinOfArray(double[] array)
    {
        double currentMin = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentMin > array[i])
            {
                currentMin = array[i];
            }
        }
        return currentMin;
    }
    static decimal MinOfArray(decimal[] array)
    {
        decimal currentMin = decimal.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentMin > array[i])
            {
                currentMin = array[i];
            }
        }
        return currentMin;
    }
    static int MaxOfArray(int[] array)
    {
        int currentMax = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentMax < array[i])
            {
                currentMax = array[i];
            }
        }
        return currentMax;
    }
    static double MaxOfArray(double[] array)
    {
        double currentMax = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentMax < array[i])
            {
                currentMax = array[i];
            }
        }
        return currentMax;
    }
    static decimal MaxOfArray(decimal[] array)
    {
        decimal currentMax = decimal.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentMax < array[i])
            {
                currentMax = array[i];
            }
        }
        return currentMax;
    }
    static int AvgOfAray (int[] array)
    {
        int average;
        average = SumOfArray(array) / array.Length;
        return average;
    }
    static double AvgOfAray(double[] array)
    {
        double average;
        average = SumOfArray(array) / array.Length;
        return average;
    }
    static decimal AvgOfAray(decimal[] array)
    {
        decimal average;
        average = SumOfArray(array) / array.Length;
        return average;
    }
    static int ProductOfArray(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
    static double ProductOfArray(double[] array)
    {
        double product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
    static decimal ProductOfArray(decimal[] array)
    {
        decimal product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
}

