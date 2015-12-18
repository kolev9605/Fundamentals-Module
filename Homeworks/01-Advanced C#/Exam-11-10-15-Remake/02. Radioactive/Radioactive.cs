using System;
using System.Collections.Generic;
using System.Linq;

class Radioactive
{
    static bool hasDied = false;
    private static bool hasWon = false;
    static void Main()
    {
        //matric dimentions
        int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //getting the values
        int rowsOfArray = dimentions[0];
        int colsOfArray = dimentions[1];
        //init the matrix
        char[,] matrix = new char[rowsOfArray, colsOfArray];
        //fill the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string lineOfMatrix = Console.ReadLine();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = lineOfMatrix[col];
            }
        }
        //read the commands
        string commands = Console.ReadLine();
        //list of bunnies coordinates
        List<int[]> bunnyCoordinates = new List<int[]>();
        //array of player coordinates
        int[] playerCoordinates = new int[2];
        LocateThePlayer(playerCoordinates, matrix);
        foreach (var command in commands)
        {
            if (hasWon||hasDied)
            {
                break;
            }
            LocateTheBunnies(bunnyCoordinates, matrix);
            MoveThePlayer(matrix, command, playerCoordinates,bunnyCoordinates);
            SpreadTheBunnies(matrix, bunnyCoordinates, playerCoordinates);
        }
    }

    private static void LoseGame(char[,] matrix, int[] playerCoordinates)
    {
        PrintMatrix(matrix);
        Console.WriteLine("dead: {0} {1}", playerCoordinates[0], playerCoordinates[1]);
    }

    private static void WinGame(char[,] matrix, int[] playerCoordinates)
    {
        PrintMatrix(matrix);
        Console.WriteLine("won: {0} {1}", playerCoordinates[0], playerCoordinates[1]);
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void SpreadTheBunnies(char[,] matrix, List<int[]> bunnyCoordinates,int[] playerCoordinates)
    {
        foreach (var currentCoordinate in bunnyCoordinates)
        {
            if (currentCoordinate[0] + 1 >= 0 && currentCoordinate[0] + 1 < matrix.GetLength(0))
            {
                //row+1
                if (matrix[currentCoordinate[0] + 1, currentCoordinate[1]] == 'P')
                {
                    hasDied = true;
                }
                matrix[currentCoordinate[0] + 1, currentCoordinate[1]] = 'B';
            }
            if (currentCoordinate[1] + 1 >= 0 && currentCoordinate[1] + 1 < matrix.GetLength(1))
            {
                //col+1
                if (matrix[currentCoordinate[0], currentCoordinate[1] + 1] == 'P')
                {
                    hasDied = true;
                }
                matrix[currentCoordinate[0], currentCoordinate[1] + 1] = 'B';
            }
            if (currentCoordinate[0] - 1 >= 0 && currentCoordinate[0] - 1 < matrix.GetLength(0))
            {
                //row-1
                if (matrix[currentCoordinate[0] - 1, currentCoordinate[1]] == 'P')
                {
                    hasDied = true;
                }
                matrix[currentCoordinate[0] - 1, currentCoordinate[1]] = 'B';
            }
            if (currentCoordinate[1] - 1 >= 0 && currentCoordinate[1] - 1 < matrix.GetLength(1))
            {
                //col-1
                if (matrix[currentCoordinate[0], currentCoordinate[1] - 1] == 'P')
                {
                    hasDied = true;
                }
                matrix[currentCoordinate[0], currentCoordinate[1] - 1] = 'B';
            }
        }
        if (hasDied)
        {
            LoseGame(matrix, playerCoordinates);
        }
    }

    private static void LocateThePlayer(int[] playerCoordinates, char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 'P')
                {
                    playerCoordinates[0] = row;
                    playerCoordinates[1] = col;
                    return;
                }
            }
        }
    }

    private static void MoveThePlayer(char[,] matrix, char command, int[] playerCoordinates, List<int[]> bunnyCoordinates)
    {
        switch (command)
        {
            case 'U':
                {
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    playerCoordinates[0]--;

                    if (playerCoordinates[0] < 0)
                    {
                        playerCoordinates[0]++;
                        hasWon = true;
                        SpreadTheBunnies(matrix, bunnyCoordinates, playerCoordinates);
                        WinGame(matrix,playerCoordinates);
                    }
                    else
                    {
                        if (matrix[playerCoordinates[0], playerCoordinates[1]] == 'B')
                        {
                            hasDied = true;
                            //LoseGame(matrix, playerCoordinates);
                            break;
                        }
                        matrix[playerCoordinates[0], playerCoordinates[1]] = 'P';
                    }
                    break;
                }
            case 'D':
                {
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    playerCoordinates[0]++;
                    if (playerCoordinates[0] >= matrix.GetLength(0))
                    {
                        playerCoordinates[0]--;
                        hasWon = true;
                        SpreadTheBunnies(matrix, bunnyCoordinates, playerCoordinates);
                        WinGame(matrix, playerCoordinates);
                    }
                    else
                    {
                        if (matrix[playerCoordinates[0], playerCoordinates[1]] == 'B')
                        {
                            hasDied = true;
                            //LoseGame(matrix, playerCoordinates);
                            break;
                        }
                        matrix[playerCoordinates[0], playerCoordinates[1]] = 'P';
                    }
                    break;
                }
            case 'R':
                {
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    playerCoordinates[1]++;
                    if (playerCoordinates[1] >= matrix.GetLength(1))
                    {
                        playerCoordinates[1]--;
                        hasWon = true;
                        SpreadTheBunnies(matrix, bunnyCoordinates, playerCoordinates);
                        WinGame(matrix, playerCoordinates);
                    }
                    else
                    {
                        if (matrix[playerCoordinates[0], playerCoordinates[1]] == 'B')
                        {
                            hasDied = true;
                            //LoseGame(matrix, playerCoordinates);
                            break;
                        }
                        matrix[playerCoordinates[0], playerCoordinates[1]] = 'P';
                    }
                    break;
                }
            case 'L':
                {
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    playerCoordinates[1]--;
                    if (playerCoordinates[1] < 0)
                    {
                        playerCoordinates[1]++;
                        hasWon = true;
                        SpreadTheBunnies(matrix, bunnyCoordinates, playerCoordinates);
                        WinGame(matrix, playerCoordinates);
                    }
                    else
                    {
                        if (matrix[playerCoordinates[0], playerCoordinates[1]] == 'B')
                        {
                            hasDied = true;
                            //LoseGame(matrix, playerCoordinates);
                            break;
                        }
                        matrix[playerCoordinates[0], playerCoordinates[1]] = 'P';
                    }
                    break;
                }
        }
    }

    private static void LocateTheBunnies(List<int[]> bunnyCoordinates, char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 'B')
                {
                    bunnyCoordinates.Add(new int[] { row, col });
                }
            }
        }
    }
}