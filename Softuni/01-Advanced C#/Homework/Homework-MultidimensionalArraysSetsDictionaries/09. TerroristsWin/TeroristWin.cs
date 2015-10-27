using System;
using System.Collections.Generic;

class TeroristWin
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('|'); //Getting the input
        List<string> bombs = new List<string>(); //List where we hold our "bombs"
        for (int i = 0; i < input.Length; i++) //Extracting the "bombs" from the input 
        {
            if (i%2!=0)
            {
                bombs.Add(input[i]);
            }
        }
        List<int> lastDigitOfBombs =  new List<int>();
        List<int> idexesOfBombWalls = new List<int>();
        for (int i = 0; i < bombs.Count; i++) //Getting the codes of the bombs' chars
        {
            char[] currentBomb = bombs[i].ToCharArray();
            int currentSum = 0;
            for (int j = 0; j < currentBomb.Length; j++) //Calculating the sum
            {
                currentSum = currentSum + (int) currentBomb[j];
            }
            lastDigitOfBombs.Add(currentSum%10); //saving only the last digit
        }
        String.Join("", input);
        Console.WriteLine(input);

    }
}