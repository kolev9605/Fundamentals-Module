using _02_Statick_Members_and_Namespaces;
using System;
using System.IO;

public static class Storage
{

    public static void Read()
    {
        StreamReader reader = new StreamReader("../../text.txt");
        using (reader)
        {
            int lineNUmber = 0;
            string line = reader.ReadLine();
            if (line == null)
            {
                throw new IOException("File is empty");
            }

            while (line != null)
            {
                lineNUmber++;
                Console.WriteLine("Point #{0}: [{1}]", lineNUmber, line);

                line = reader.ReadLine();
            }
        }
    }

    public static void Write(Path3D path)
    {
        StreamWriter writer = new StreamWriter("../../text.txt");

        using (writer)
        {
            int lineNumber = 0;
            foreach (var item in path.Path)
            {
                lineNumber++;
                writer.WriteLine("Point #{0}: [{1}];", lineNumber, item);
            }
        }
    }
}