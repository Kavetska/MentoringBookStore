namespace AmazonCosplay.Interfaces
{
    using System;
    using Microsoft.EntityFrameworkCore;
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        void Commit();
    }
}
