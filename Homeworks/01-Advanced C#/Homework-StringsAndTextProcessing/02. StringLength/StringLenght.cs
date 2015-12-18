using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLenght
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length==20)
        {
            Console.WriteLine(input);
        }
        else if (input.Length>20)
        {
            Console.WriteLine(input.Substring(0,20));
        }
        else
        {
            Console.WriteLine(input + new string('*',20-input.Length));
        }
    }
}
