using System;

internal class CollectTheCoins
{
    private static void Main()
    {
        //filling the array
        string[][] board = new string[4][];
        for (int i = 0; i < board.GetLength(0); i++)
        {
            string field = Console.ReadLine();
            char[] fieldParts;
            fieldParts = field.ToCharArray();
            board[i] = new string[field.Length];

            for (int j = 0; j < field.Length; j++)
            {
                board[i][j] = fieldParts[j].ToString();
            }
        }
        //body
        string command = Console.ReadLine();
        char[] commandParts;
        commandParts = command.ToCharArray();
        int currentRow = 0;
        int currentCol = 0;
        int wallCount = 0;
        int coinCount = 0;
        for (int i = 0; i < commandParts.Length; i++)
        {
            switch (commandParts[i])
            {
                case 'v':
                case 'V':
                    {
                        currentRow++;
                        if (currentCol < 0 || currentRow < 0 || currentRow >= board.GetLength(0) || currentCol >= board[currentRow].Length)
                        {
                            wallCount++;
                            currentRow--;
                            break;
                        }
                        if (board[currentRow][currentCol] == "$")
                        {
                            coinCount++;
                        }
                        break;
                    }
                case '>':
                    {
                        currentCol++;
                        if (currentCol < 0 || currentRow < 0 || currentRow >= board.GetLength(0) || currentCol >= board[currentRow].Length)
                        {
                            wallCount++;
                            currentCol--;
                            break;
                        }
                        if (board[currentRow][currentCol] == "$")
                        {
                            coinCount++;
                        }
                        break;
                    }
                case '<':
                    {
                        currentCol--;
                        if (currentCol < 0 || currentRow < 0 || currentRow >= board.GetLength(0) || currentCol >= board[currentRow].Length)
                        {
                            wallCount++;
                            currentCol++;
                            break;
                        }
                        if (board[currentRow][currentCol] == "$")
                        {
                            coinCount++;
                        }
                        break;
                    }
                case '^':
                    {
                        currentRow--;
                        if (currentCol < 0 || currentRow < 0||currentRow >= board.GetLength(0) || currentCol >= board[currentRow].Length)
                        {
                            wallCount++;
                            currentRow++;
                            break;
                        }
                        if (board[currentRow][currentCol] == "$")
                        {
                            coinCount++;
                        }
                        break;
                    }
            }
        }
        Console.WriteLine("Coins collected: {0}", coinCount);
        Console.WriteLine("Walls hit: {0}", wallCount);
    }
}