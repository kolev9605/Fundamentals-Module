using System;
using System.Diagnostics;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (var reader = new StreamReader("../../examplefile.txt"))
        {
            using (var writer = new StreamWriter("../../modifiedfile.txt"))
            {
                string line = reader.ReadLine();
                int count = 0;
                while (line != null)
                {
                    writer.WriteLine(count + " " + line);
                    count++;
                    line = reader.ReadLine();
                }
            }
        }

    }
}