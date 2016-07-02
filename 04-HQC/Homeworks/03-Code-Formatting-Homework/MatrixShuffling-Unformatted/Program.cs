using System;
using System.Linq;

class MatrixShuffling
{
    static void Main()
    {
        //input
        int rows;
        rows = int.Parse(Console.ReadLine());
        int cols;
        cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = int.Parse(Console.ReadLine());
        
        //body
        int swap = 0;
        string[] command = Console.ReadLine().Split(' ');
        int firstRow = int.Parse(command[1]);
        int firstCol = int.Parse(command[2]);
        int secondRow = int.Parse(command[3]);
        int secondCol = int.Parse(command[4]);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}, ", matrix[i, j]);
            }
            Console.WriteLine();
        }

        while (command[0] != "END")
        {



            if (command.Length == 5)
            {
                firstRow = int.Parse(command[1]);
                firstCol = int.Parse(command[2]);
                secondRow = int.Parse(command[3]);
                secondCol = int.Parse(command[4]);
                if (command[0] == "swap")
                {
                    if ((firstRow >= 0 && firstCol >= 0 && secondRow >= 0 && secondCol >= 0) &&
                        (firstRow <= rows && firstCol <= cols && secondRow <= rows && secondCol <= cols))
                    {
                        //swap
                        swap = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = swap;
                        Console.WriteLine();
                        Console.WriteLine("After swapping {0} and {1} the result is:", matrix[firstRow, firstCol],
                            matrix[secondRow, secondCol]);
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write("{0}, ", matrix[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            command = Console.ReadLine().Split(' ');
        }
    }
}



