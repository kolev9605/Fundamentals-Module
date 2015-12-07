using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string command = Console.ReadLine();
        while (command != "end")
        {
            ExecuteTheCommand(command, array);
            command = Console.ReadLine();
        }
        Console.WriteLine("["+(string.Join(", ",array))+"]");
    }

    static void ExecuteTheCommand(string command, List<int> array)
    {
        string[] commandParts = command.Split(' ');
        switch (commandParts[0])
        {
            case "exchange":
                {
                    ExchangeCommand(array, commandParts);
                    break;
                }
            case "max":
                {
                    MaxCommand(array, commandParts);
                    break;
                }
            case "min":
                {
                    MinCommand(array, commandParts);
                    break;
                }
            case "first":
                {
                    FirstCommand(array, commandParts);
                    break;
                }
            case "last":
                {
                    LastCommand(array, commandParts);
                    break;
                }
        }
    }

    static void ExchangeCommand(List<int> array, string[] commandParts)
    {
        int index = int.Parse(commandParts[1]);
        if (index < 0 || index >= array.Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }
        for (int i = 0; i <= index; i++)
        {
            array.Add(array[0]);
            array.Remove(array[0]);
        }
    }

    static void MaxCommand(List<int> array, string[] commandParts)
    {
        string evenOrOdd = commandParts[1];
        if (evenOrOdd == "even")
        {
            //max even
            int currentMax = int.MinValue;
            int currentMaxIndex = -1;
            for (int i = 0; i < array.Count; i++)
            {
                if (currentMax <= array[i] && array[i] % 2 == 0)
                {
                    currentMax = array[i];
                    currentMaxIndex = i;
                }
            }
            if (currentMaxIndex != -1)
            {
                Console.WriteLine(currentMaxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
        else if (evenOrOdd == "odd")
        {
            //max odd
            int currentMax = int.MinValue;
            int currentMaxIndex = -1;
            for (int i = 0; i < array.Count; i++)
            {
                if (currentMax <= array[i] && array[i] % 2 != 0)
                {
                    currentMax = array[i];
                    currentMaxIndex = i;
                }
            }
            if (currentMaxIndex != -1)
            {
                Console.WriteLine(currentMaxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }

    private static void MinCommand(List<int> array, string[] commandParts)
    {
        string evenOrOdd = commandParts[1];
        if (evenOrOdd == "even")
        {
            //min even
            int currentMin = int.MaxValue;
            int currentMinIndex = -1;
            for (int i = 0; i < array.Count; i++)
            {
                if (currentMin >= array[i] && array[i] % 2 == 0)
                {
                    currentMin = array[i];
                    currentMinIndex = i;
                }
            }
            if (currentMinIndex != -1)
            {
                Console.WriteLine(currentMinIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        else //if (evenOrOdd == "odd")
        {
            //min odd
            int currentMin = int.MaxValue;
            int currentMinIndex = -1;
            for (int i = 0; i < array.Count; i++)
            {
                if (currentMin >= array[i] && array[i] % 2 != 0)
                {
                    currentMin = array[i];
                    currentMinIndex = i;
                }
            }
            if (currentMinIndex != -1)
            {
                Console.WriteLine(currentMinIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }

    static void FirstCommand(List<int> array, string[] commandParts)
    {
        int count = int.Parse(commandParts[1]);
        if (count > array.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        string evenOrOdd = commandParts[2];
        List<int> output = new List<int>();
        int elementsAdded = 0;
        if (evenOrOdd == "even")
        {
            while (true)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (elementsAdded == count)
                    {
                        break;
                    }
                    if (array[i] % 2 == 0)
                    {
                        output.Add(array[i]);
                        elementsAdded++;
                    }
                }
                break;
            }
            if (elementsAdded != 0)
            {
                Console.WriteLine("[" + (string.Join(", ", output)) + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        else //if (evenOrOdd=="odd")
        {
            while (true)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (elementsAdded == count)
                    {
                        break;
                    }
                    if (array[i] % 2 != 0)
                    {
                        output.Add(array[i]);
                        elementsAdded++;
                    }
                }
                break;
            }
            if (elementsAdded != 0)
            {
                Console.WriteLine("[" + (string.Join(", ", output)) + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
    }

    static void LastCommand(List<int> array, string[] commandParts)
    {
        int count = int.Parse(commandParts[1]);
        if (count > array.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        string evenOrOdd = commandParts[2];
        List<int> output = new List<int>();
        int elementsAdded = 0;
        if (evenOrOdd == "even")
        {
            while (true)
            {
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    if (elementsAdded == count)
                    {
                        break;
                    }
                    if (array[i] % 2 == 0)
                    {
                        output.Add(array[i]);
                        elementsAdded++;
                    }
                }
                break;
            }
            if (elementsAdded != 0)
            {
                //output.Reverse();
                Console.WriteLine("[" + (string.Join(", ", output)) + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        else
        {
            while (true)
            {
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    if (elementsAdded == count)
                    {
                        break;
                    }
                    if (array[i] % 2 != 0)
                    {
                        output.Add(array[i]);
                        elementsAdded++;
                    }
                }
                break;
            }
            if (elementsAdded != 0)
            {
                //output.Reverse();
                Console.WriteLine("[" + (string.Join(", ", output)) + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
    }
}