namespace _08_DistanceInLabyrinth
{
    using System;
    using System.Collections.Generic;

    class DistanceLabyrinth
    {
        private static string unreachableCellSymbol = "u";
        private static string startingCellSymbol = "*";
        private static int startingIndex = 1;
        private static int childrenCounter = 0;

        static void Main(string[] args)
        {
            string[,] matrix = new string[,]
            {
                { "0", "0", "0", "x", "0", "x" },
                { "0", "x", "0", "x", "0", "x" },
                { "0", "*", "x", "0", "x", "0" },
                { "0", "x", "0", "0", "0", "0" },
                { "0", "0", "0", "x", "x", "0" },
                { "0", "0", "0", "x", "0", "x" }
            };

            CalculateDistances(matrix);
            MarkUnreachableCells(matrix);
            PrintMatrix(matrix);
        }

        private static void CalculateDistances(string[,] matrix)
        {
            Queue<Tuple<int, int>> cellsQueue = new Queue<Tuple<int, int>>();
            Tuple<int, int> startingCell = FindStartingCell(matrix);
            cellsQueue.Enqueue(startingCell);
            int counter = startingIndex;
            childrenCounter = 1;
            while (cellsQueue.Count > 0)
            {
                int tempChildrenCounter = 0;
                while (childrenCounter > 0)
                {
                    Tuple<int, int> currentCell = cellsQueue.Dequeue();
                    childrenCounter--;
                    EnqueueNearbyCells(cellsQueue, matrix, currentCell, counter, ref tempChildrenCounter);
                }

                counter++;
                childrenCounter = tempChildrenCounter;
            }
        }

        private static void EnqueueNearbyCells(Queue<Tuple<int, int>> cellsQueue, string[,] matrix, Tuple<int, int> currentCell, int counter, ref int tempChildrenCounter)
        {
            AddToQueue(cellsQueue, matrix, currentCell.Item1 - 1, currentCell.Item2, counter, ref tempChildrenCounter);
            AddToQueue(cellsQueue, matrix, currentCell.Item1 + 1, currentCell.Item2, counter, ref tempChildrenCounter);
            AddToQueue(cellsQueue, matrix, currentCell.Item1, currentCell.Item2 - 1, counter, ref tempChildrenCounter);
            AddToQueue(cellsQueue, matrix, currentCell.Item1, currentCell.Item2 + 1, counter, ref tempChildrenCounter);
        }

        private static void AddToQueue(Queue<Tuple<int, int>> cellsQueue, string[,] matrix, int x, int y, int counter, ref int tempChildrenCounter)
        {
            if (x < 0 || y < 0 || x >= matrix.GetLength(0) || y >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[x, y] != "0")
            {
                return;
            }

            matrix[x, y] = counter.ToString();
            tempChildrenCounter++;
            cellsQueue.Enqueue(new Tuple<int, int>(x, y));
        }

        private static Tuple<int, int> FindStartingCell(string[,] matrix)
        {
            int startX = 0;
            int startY = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == startingCellSymbol)
                    {
                        startX = i;
                        startY = j;
                        break;
                    }
                }
            }

            return new Tuple<int, int>(startX, startY);
        }

        private static void MarkUnreachableCells(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "0")
                    {
                        matrix[i, j] = unreachableCellSymbol;
                    }
                }
            }
        }

        private static void PrintMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,2}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}