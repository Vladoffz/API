using FootballManager.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace FootballManager.Bl.Abstract
{
    public interface IChampionshipCommandService : IRepositoryChampionshipCommand, IGenericService<ChampionshipCommandDTO>
    {
        public List<ChampionshipCommandDTO> List();
        public void Insert(ChampionshipCommandDTO _ChampionshipCommand);
        public ChampionshipCommandDTO Get(int ID);
        public void Update(ChampionshipCommandDTO model);
    }
}
