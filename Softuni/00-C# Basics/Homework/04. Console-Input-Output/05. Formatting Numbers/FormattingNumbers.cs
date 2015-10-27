//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. Examples:

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please enter a (0 <= a <= 500): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter c: ");
        double c = double.Parse(Console.ReadLine());
        string hexValue = a.ToString("X");
        string binaryValue = Convert.ToString(a, 2).PadLeft(10, '0');

        Console.WriteLine("|{0,10}|{1,-10:D10}|{2,10:F2}|{3,-10:F3}|", hexValue, binaryValue, b, c);



    }
}

