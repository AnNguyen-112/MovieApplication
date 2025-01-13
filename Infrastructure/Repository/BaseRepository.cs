using ApplicationCore.Contracts;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly MovieDbContext _context;
        public BaseRepository(MovieDbContext context)
        {
            _context = context;
        }
        public int Delete(int id)
        {
            T obj = GetById(id);
            if (obj != null)
            {
                _context.Set<T>().Remove(obj);
            }

            return _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<T> Search(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public int Update(T entity, int id)
        {
            _context.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
