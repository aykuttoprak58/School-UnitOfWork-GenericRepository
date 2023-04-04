using Microsoft.EntityFrameworkCore;
using School.DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccessLayer.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public SchoolDbContext context;
        public DbSet<T> dbSet;
        public GenericRepository(SchoolDbContext contex2)
        {
            context = contex2;
            dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
     
        }

        public void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
  
        }

        public IEnumerable<T> GetAll()
        {
            var school = dbSet.ToList();

            return school;
        }

        public T GetById(int id)
        {
            var school = dbSet.Find(id);
            return school;
        }

        public void Remove(int id)
        {
            var schoolid = dbSet.Find(id);

            var school = dbSet.Remove(schoolid);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            var personel = dbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            dbSet.UpdateRange(entities);
        }
    }
 
}
