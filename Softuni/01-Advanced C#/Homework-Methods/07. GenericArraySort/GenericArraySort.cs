using System;
using System.Collections.Generic;
using System.Linq;

class GenericArraySort
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates =
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)
        };
        SortArray(numbers);
        SortArray(strings);
        SortArray(dates);
    }

    private static void SortArray<T>(IEnumerable<T> array)
    {
        List<T> unSortedList = array.ToList();
        List<T> sortedList = new List<T>();
        while (unSortedList.Count != 0)
        {
            var minValue = unSortedList.Min();
            sortedList.Add(minValue);
            unSortedList.Remove(minValue);
        }
        PrintArray(sortedList);
    }

    private static void PrintArray<T>(IEnumerable<T> list)
    {
        foreach (var element in list)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
}
