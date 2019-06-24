namespace AmazonCosplay.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T GetById(int? id);
        void Add(T entity);
        void DeleteById(int? id);
        void Update(T entity);

    }
}
