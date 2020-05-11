using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Impl;
using FootballManager.Entities;

namespace FootballManager.DAL.Abstract
{
    public interface IRepositoryChampionship : IGenericRepository<Championship>
    {
        public IEnumerable<Championship> FindByNameEntity(string Name);
    }
}


