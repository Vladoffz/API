using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FootballManager.DAL.Impl
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
       
            protected readonly FootballManagerContext _DBContext;

            public GenericRepository(FootballManagerContext dbContext)
            {
                _DBContext = dbContext;
            }

            public void DeleteEntity(T entity)
            {
                _DBContext.Set<T>().Remove(entity);
                _DBContext.SaveChanges();
            }

            public void DeleteEntity(int id)
            {
            this.DeleteEntity(this.GetEntity(id));
            }

            public T GetEntity(int ID)
            {
                return _DBContext.Set<T>().Find(ID);
            }

            public void InsertEntity(T entity)
            {
                _DBContext.Set<T>().Add(entity);
                _DBContext.SaveChanges();
            }

            public IList<T> ListEntities()
            {
                return _DBContext.Set<T>().ToList();
            }

            public IList<T> ListEntities(Expression<Func<T, bool>> expression)
            {
                return _DBContext.Set<T>().Where(expression).ToList();
            }

            public void UpdateEntity(T entity)
            {
                _DBContext.Entry<T>(entity).State = EntityState.Modified;
                _DBContext.SaveChanges();
            }
        }
    }
