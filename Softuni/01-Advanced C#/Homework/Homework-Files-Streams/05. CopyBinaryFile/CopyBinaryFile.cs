using System;
using System.IO;
using System.Text;

class CopyBinaryFile
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        FileStream binaryFileStream = new FileStream("../../faker.png", FileMode.Open);
        FileStream copyFile = new FileStream("../../faker-copy.png", FileMode.OpenOrCreate);
        try
        {
            byte line = (byte)binaryFileStream.ReadByte();
            while (binaryFileStream.Position < binaryFileStream.Length)
            {
                copyFile.WriteByte((byte)binaryFileStream.ReadByte());
            }
        }
        finally
        {
            binaryFileStream.Close();
        }

    }
}