using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        //int[] numbers = { 1, 3, 4, 5, 1, 0, 5, };
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsBigger(numbers,i));
        }
    }
    static bool IsBigger(int[] arr, int index)
    {
        if (index==0)
        {
            if (arr[index]>arr[index+1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (index==arr.Length-1)
        {
            if (arr[index] > arr[index -1])
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