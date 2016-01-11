namespace Empires.IO
{
    using System;
    using Interfaces;
    class ConsoleWriter : IOutputWriter
    {
        public void Write(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
