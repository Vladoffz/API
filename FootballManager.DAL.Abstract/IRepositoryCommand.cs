using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Impl;
using FootballManager.Entities;

namespace FootballManager.DAL.Abstract
{
    public interface IRepositoryCommand : IGenericRepository<Command>
    {
        public IEnumerable<Command> FindByNameEntity(string Name);
        public IEnumerable<Command> FindByCountryEntity(string Country);
    }
}
