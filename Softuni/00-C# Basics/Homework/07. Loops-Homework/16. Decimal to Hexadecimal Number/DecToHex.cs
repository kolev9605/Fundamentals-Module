using System;

class DecToHex
{
    static void Main()
    {
        long decInput = long.Parse(Console.ReadLine());
        string hexOutupt = "";
        long rest=0;
        while (decInput != 0)
        {
            rest = decInput % 16;
            switch (rest)
            {
                case 10:
                    hexOutupt = "A" + hexOutupt;
                    break;
                case 11:
                    hexOutupt = "B" + hexOutupt;
                    break;
                case 12:
                    hexOutupt = "C" + hexOutupt;
                    break;
                case 13:
                    hexOutupt = "D" + hexOutupt;
                    break;
                case 14:
                    hexOutupt = "E" + hexOutupt;
                    break;
                case 15:
                    hexOutupt = "F" + hexOutupt;
                    break;
                default:
                    hexOutupt = rest + hexOutupt;
                    break;
            }
            decInput /= 16;
        }
        Console.WriteLine(hexOutupt);
    }
}

