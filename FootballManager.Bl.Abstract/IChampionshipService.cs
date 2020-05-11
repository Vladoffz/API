using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Abstract;
using Models;

namespace FootballManager.Bl.Abstract
{
    public interface IChampionshipService : IRepositoryChampionship, IGenericService<ChampionshipDTO>
    {
        public List<ChampionshipDTO> List();
        public List<ChampionshipDTO> FindByName(string Name);
        public void Insert(ChampionshipDTO _Championship);
        public ChampionshipDTO Get(int ID);
        public void Update(ChampionshipDTO model);
    }
}
