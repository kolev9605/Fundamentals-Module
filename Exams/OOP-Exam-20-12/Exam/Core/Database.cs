namespace Exam.Core
{
    using System;
    using System.Collections.Generic;
    using Interface;

    class Database : IDatabase
    {
        private readonly IList<IBlob> blobs = new List<IBlob>();

        public IEnumerable<IBlob> Blobs => this.blobs;

        public void AddBlob(IBlob blob)
        {
            if (blob==null)
            {
                throw new NullReferenceException(Messeges.NullBlobReference);
            }
            this.blobs.Add(blob);
        }
    }
}
