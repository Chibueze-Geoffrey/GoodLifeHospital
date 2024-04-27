using GoodLifeHospital.DatabaseContext;
using GoodLifeHospital.Services.Interfaces;
using System.Linq.Expressions;

namespace GoodLifeHospital.Services.Implementations
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected GoodLifeContext _context;
        public GenericRepository(GoodLifeContext context)
        {
            _context = context;
        }
        public virtual T Add(T entity)
        {
          var addedEntity =  _context.Add(entity).Entity;
            return addedEntity;
        }
        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> Predicate)
        {
            var result = _context.Set<T>().AsQueryable()
                .Where(Predicate)
                .ToList();
            return result;
        }
        public virtual T Get(string id)
        {
            return _context.Find<T>(id);
        }
        public virtual IEnumerable<T> All()
        {
            var all = _context.Set<T>().ToList();
            return all;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public virtual T Update(T entity)
        {
            var updatedEntity = _context.Update(entity).Entity;
            return updatedEntity;
        }
    }
}
