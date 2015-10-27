using System;
using System.Globalization;

internal class Program
{
    private static void Main()
    {
        Console.Write("rows: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("columns: ");
        int col = int.Parse(Console.ReadLine());
        string output = "";
        int printer = 0;
        for (int i = 0; i < row; i++)
        {

            for (int j = 0; j < col; j++)
            {
                output = new string((char)(97 + i), 1) + new string((char)(97 + printer), 1) + new string((char)(97 + i), 1);
                Console.Write(output + " ");
                printer++;
            }
            printer = i + 1;
            Console.WriteLine();
        }
    }
}

