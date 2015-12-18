namespace Empires.IO
{
    using System;
    using Interfaces;
    class ConsoleReader : IInputReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
