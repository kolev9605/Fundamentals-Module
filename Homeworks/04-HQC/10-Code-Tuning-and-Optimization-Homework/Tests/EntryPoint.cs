namespace Tests
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main()
        {
            int n = 1000;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < int.MaxValue; i++)
            {
                int x = n - i;
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}