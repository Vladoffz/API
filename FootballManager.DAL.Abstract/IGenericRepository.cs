using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FootballManager.DAL.Abstract;

namespace FootballManager.DAL.Impl
{
    //TODO: make generic repository
    public interface IGenericRepository<T> where T : class
    {
        T GetEntity(int id);
        IList<T> ListEntities();
        IList<T> ListEntities(Expression<Func<T, bool>> expression);
        void InsertEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
        void DeleteEntity(int id);
    }
}
