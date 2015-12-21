using System;

namespace Exam.IO
{
    using Interface;
    class ConsoleUserInterface : IUserInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string messege)
        {
            Console.WriteLine(messege);
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
