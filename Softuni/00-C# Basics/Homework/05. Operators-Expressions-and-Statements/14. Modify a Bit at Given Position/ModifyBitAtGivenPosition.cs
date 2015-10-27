using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());     //5         0000 0101
        int position = int.Parse(Console.ReadLine());   //2         
        int bitValue = int.Parse(Console.ReadLine());   //0

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        int modifiedNumber;

        if (bitValue==0)
        {
            modifiedNumber = ~(1 << position) & number;
        }
        else
        {
            modifiedNumber = (bitValue << position) | number;  
        }
        Console.WriteLine(Convert.ToString(modifiedNumber, 2).PadLeft(16, '0'));

        Console.WriteLine(modifiedNumber);
    }
}

