namespace Exam.Interface
{
    using System.Collections.Generic;

    interface IDatabase
    {
        IEnumerable<IBlob> Blobs { get; }
        void AddBlob(IBlob blob);
    }
}
