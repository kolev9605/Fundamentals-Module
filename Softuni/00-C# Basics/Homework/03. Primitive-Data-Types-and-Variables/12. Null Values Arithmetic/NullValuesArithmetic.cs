using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
        intNull += 5;
        doubleNull += 1.534;
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
    }
}

