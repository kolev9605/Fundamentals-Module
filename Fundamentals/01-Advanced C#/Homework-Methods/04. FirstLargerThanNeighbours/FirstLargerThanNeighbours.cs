using System;
using System.Collections.Generic;
using System.Linq;

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element. Use the method from the previous exercise in order to re.

class FirstLargerThanNeighbours
{
    static void Main()
    {
        //int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(FirstLargerElement(numbers));
    }

    static int FirstLargerElement(int[] sequence)
    {
        int biggestIndex= -1;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (IsBigger(sequence, i) == true)
            {
                biggestIndex = i;
                break;
            }
        }
        return biggestIndex;

    }

    static bool IsBigger(int[] arr, int index)
    {
        if (index == 0)
        {
            if (arr[index] > arr[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (index == arr.Length - 1)
        {
            if (arr[index] > arr[index - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
