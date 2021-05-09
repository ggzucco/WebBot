using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace WebBotModule.DBI
{
    public interface IRepositoryDBI<TEntity> where TEntity : class
    {
        TEntity Get(Int64 id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
