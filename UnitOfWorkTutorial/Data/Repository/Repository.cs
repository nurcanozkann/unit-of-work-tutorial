using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkTutorial.Entities;

namespace UnitOfWorkTutorial.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntitiy
    {
        private UoWContext context;
        public Repository(UoWContext _context)
        {
            context = _context;
        }

        public void Add(T entity)
        {
            var currentEntity = context.Entry(entity);
            currentEntity.State = EntityState.Added;
        }

        public void Delete(T entity)
        {
            var currentEntity = context.Entry(entity);
            currentEntity.State = EntityState.Deleted;
        }

        public void Delete(int id)
        {
            var currentEntity = context.Set<T>().SingleOrDefault(z => z.Id == id);
            context.Set<T>().Remove(currentEntity);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().SingleOrDefault(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            var currentEntity = context.Entry(entity);
            currentEntity.State = EntityState.Modified;
        }
    }
}
