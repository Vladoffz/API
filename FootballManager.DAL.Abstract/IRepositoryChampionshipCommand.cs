using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Impl;
using FootballManager.Entities;

namespace FootballManager.DAL.Abstract
{
    public interface IRepositoryChampionshipCommand : IGenericRepository<ChampionshipCommand>
    {
        public IEnumerable<ChampionshipCommand> FindByNameEntity(string Name);
        public List<ChampionshipCommand> GetListDownToTheRoot();
    }
}
