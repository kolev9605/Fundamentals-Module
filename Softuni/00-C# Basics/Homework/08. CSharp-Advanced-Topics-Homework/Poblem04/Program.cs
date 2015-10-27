using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateTime firstToDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.CurrentCulture);
        DateTime secondToDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.CurrentCulture);
        Console.WriteLine((secondToDate-firstToDate).TotalDays);
    }
}

