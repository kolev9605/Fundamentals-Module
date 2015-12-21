namespace Exam.Exceptions
{
    using System;

    class FactoryException : Exception
    {
        public FactoryException(string messege)
            :base(messege)
        {
        }
    }
}