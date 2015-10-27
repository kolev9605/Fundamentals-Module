using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = (weightOnEarth * 17) / 100;
        Console.WriteLine("{0} on Earth is {1} on the Moon.", weightOnEarth, weightOnMoon);

    }
}

