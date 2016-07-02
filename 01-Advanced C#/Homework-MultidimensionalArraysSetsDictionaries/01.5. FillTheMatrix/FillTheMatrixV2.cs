using System;
class FillTheMatrixV2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        bool goDown = true;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (goDown)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = int.Parse(Console.ReadLine());
                }
                goDown = false;
            }
            else
            {
                for (int j = n-1; j >= 0; j--)
                {
                    matrix[j, i] = int.Parse(Console.ReadLine());
                }
                goDown = true;
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}, ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

