namespace Exam.Exceptions
{
    using System;

    public class CommandException : Exception
    {
        public CommandException(string messege)
            :base (messege)
        {
        }
    }
}