namespace Exam.Exceptions
{
    using System;

    public class BlobException : Exception
    {
        public BlobException(string messege)
            : base(messege)
        {
        }
    }
}