namespace StringExtensionsProject
{
    using System;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            string x = "гошо";
            x = x.ConvertCyrillicToLatinLetters();
            Console.WriteLine(x);
        }
    }
}