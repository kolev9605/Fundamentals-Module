using System;

class DeckOfCards
{
    static void Main()
    {


        for (int cardCount = 0; cardCount < 13; cardCount++)
        {
            for (int suitCount = 3; suitCount <= 6; suitCount++)
            {
                switch (cardCount)
                {
                    case 0:
                        Console.Write(2);
                        break;
                    case 1:
                        Console.Write(3);
                        break;
                    case 2:
                        Console.Write(4);
                        break;
                    case 3:
                        Console.Write(5);
                        break;
                    case 4:
                        Console.Write(6);
                        break;
                    case 5:
                        Console.Write(7);
                        break;
                    case 6:
                        Console.Write(8);
                        break;
                    case 7:
                        Console.Write(9);
                        break;
                    case 8:
                        Console.Write(10);
                        break;
                    case 9:
                        Console.Write("J");
                        break;
                    case 10:
                        Console.Write("Q");
                        break;
                    case 11:
                        Console.Write("K");
                        break;
                    case 12:
                        Console.Write("A");
                        break;

                    default:
                        break;
                }
                Console.Write("{0} ",(char)suitCount);
            }
            Console.WriteLine();
        }

    }
}

