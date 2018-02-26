using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess
{
    public class BaseRepository<T> where T : class
    {
        private LibraryProjectDbContext context;
        private DbSet<T> dbSet;

        public BaseRepository(LibraryProjectDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T Get(int id)
        {
           return dbSet.Find(id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter).ToList();
        }

        public void Add(T entity)
        {
            context.Entry(entity).State = EntityState.Added;
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }
    }
}
