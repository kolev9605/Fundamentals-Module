namespace HotelBookingSystem.Core.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriter : IOutputWriter
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Weite(string msg)
        {
            Console.Write(msg);
        }
    }
}
