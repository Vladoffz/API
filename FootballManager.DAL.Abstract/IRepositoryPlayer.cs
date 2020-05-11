using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Impl;
using FootballManager.Entities;

namespace FootballManager.DAL.Abstract
{
    public interface IRepositoryPlayer : IGenericRepository<Player>
    {
        public IEnumerable<Player> FindByFirstNameEntity(string FirstName);
        public IEnumerable<Player> FindByAgeEntity(int Age);
    
    }
}
