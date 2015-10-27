using System;

class CheckPlayCard
{
    static void Main()
    {

        string inputString = Console.ReadLine();
        switch (inputString)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case  "J":
            case  "K":
            case  "Q":
            case  "A":

                Console.WriteLine("YES");
                break;


            default:
                Console.WriteLine("NO");
                break;
        }
    }
}

