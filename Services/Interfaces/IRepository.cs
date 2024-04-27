using System;
using System.Linq.Expressions;

namespace GoodLifeHospital.Services.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Get(string id);
        IEnumerable<T> All();
        IEnumerable<T> Find(Expression <Func<T, bool>> Predicate);
        void SaveChanges();

    }
}
