using System;

class HexToDec
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] charArr = input.ToCharArray();
        long convertedInput = 0;
        int digit = 1;
        int powerCounter = charArr.Length - 1;
        for (int i = 0; i < charArr.Length; i++)
        {
            switch (charArr[i])
            {
                case 'A':
                    digit = 10;
                    convertedInput += digit * (long)Math.Pow(16, powerCounter);
                    break;
                case 'B':
                    digit = 11;
                    convertedInput += digit * (long)Math.Pow(16, powerCounter);
                    break;
                case 'C':
                    digit = 12;
                    convertedInput += digit * (long)Math.Pow(16, powerCounter);
                    break;
                case 'D':
                    digit = 13;
                    convertedInput += digit * (long)Math.Pow(16, powerCounter);
                    break;
                case 'E':
                    digit = 14;
                    convertedInput += digit * (long)Math.Pow(16, powerCounter);
                    break;
                case 'F':
                    digit = 15;
                    convertedInput += digit * (long)Math.Pow(16, powerCounter);
                    break;
                default:
                    convertedInput += (charArr[i]-48) * (long)Math.Pow(16, powerCounter);
                    break;
            }
            powerCounter--;
        }
        Console.WriteLine(convertedInput);

    }
}

