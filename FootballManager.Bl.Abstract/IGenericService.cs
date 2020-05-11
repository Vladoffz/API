using System;
using System.Collections.Generic;
using System.Text;

namespace FootballManager.Bl.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public List<T> List();
        public void Insert(T model);
        public void Update(T model);
    }
}
