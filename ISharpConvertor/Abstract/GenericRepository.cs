using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.DAL.Abstract
{
    public class GenericRepository<T> : IBaseRepository<T> where T : class
    {

        private Entity.ISharpConvertorEntities _dbContext;


        public GenericRepository(Entity.ISharpConvertorEntities context)
        {
            _dbContext = context;

        }
        
        public Entity.ISharpConvertorEntities Context
        {
            get { return _dbContext; }
            set { _dbContext = value; }
        }


        public void Insert(T item)
        {
            _dbContext.Set<T>().Add(item);

        }

        public void Update(T item)
        {

            _dbContext.Entry(item).State = EntityState.Modified;
        }

        public void Remove(T item)
        {
            _dbContext.Set<T>().Remove(item);
        }

        public IEnumerable<T> Fetch()
        {
            return _dbContext.Set<T>().ToList();
        }

        public IEnumerable<T> FetchBy(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).ToList();
        }

        public virtual T Find(string id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> PaggingFetch(int startIndex, int count)
        {
            return _dbContext.Set<T>().Skip(startIndex).Take(count).ToList();
        }

        public IEnumerable<T> PaggingFetchBy(Expression<Func<T, bool>> predicate, int startIndex, int count)
        {
            return _dbContext.Set<T>().Where(predicate).Skip(startIndex).Take(count).ToList();
        }

      

        public int GetCount()
        {
            return _dbContext.Set<T>().Count();
        }

        public T GetById(int id)
        {
            return id > 0 ? _dbContext.Set<T>().Find(id) : null;
        }

        
        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }

        
        public void SaveContext()
        {
            _dbContext.SaveChanges();
        }

        
    }
}
