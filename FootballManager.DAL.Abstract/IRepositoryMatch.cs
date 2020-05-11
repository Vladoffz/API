using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Impl;
using FootballManager.Entities;

namespace FootballManager.DAL.Abstract
{
    public interface IRepositoryMatch : IGenericRepository<Match>
    {
        public IEnumerable<Match> FindByResultEntity(int Result);
    }
}
