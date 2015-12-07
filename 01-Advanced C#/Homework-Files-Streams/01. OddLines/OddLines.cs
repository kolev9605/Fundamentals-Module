using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../examplefile.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber+=2;
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }

    }
}