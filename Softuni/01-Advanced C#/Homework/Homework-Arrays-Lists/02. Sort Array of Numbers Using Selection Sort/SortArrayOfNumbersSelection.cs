using System;
using System.Linq;

class SortArrayOfNumbersSelection
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] sortedArr = new int[arr.Length];
        int tempMinValue;
        int swap;
        int index=0;

        for (int i = 0; i < arr.Length; i++)
        {
            index = i;
            tempMinValue = arr[i];
            for (int j = i; j < arr.Length; j++)
            {
                if (tempMinValue>arr[j])
                {
                    tempMinValue = arr[j];
                    index = j;
                }
            }
            swap = arr[i];
            arr[i] = arr[index];
            arr[index] = swap;

        }
        Console.WriteLine(string.Join(", ", arr));
    }
}

