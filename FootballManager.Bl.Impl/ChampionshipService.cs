using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.Bl.Abstract;
using FootballManager.DAL.Impl;
using FootballManager.DAL.Impl.Mappers;
using Models;

namespace FootballManager.Bl.Impl
{
    public class ChampionshipService : ChampionshipRepository, IChampionshipService
    {
        public ChampionshipService(FootballManagerContext context) : base(context)
        {

        }

        public List<ChampionshipDTO> FindByName(string Name)
        {
            return this.FindByNameEntity(Name).Select(obj => ChampionshipMapper.Map(obj)).ToList();
        }

        public ChampionshipDTO Get(int ID)
        {
            return ChampionshipMapper.Map(this.GetEntity(ID));
        }

        public void Insert(ChampionshipDTO _Championship)
        {
            this.InsertEntity(ChampionshipMapper.Unmapper(_Championship));
        }

        public List<ChampionshipDTO> List()
        {
            return this.ListEntities().Select(obj => ChampionshipMapper.Map(obj)).ToList();
        }

        public void Update(ChampionshipDTO model)
        {
            this.UpdateEntity(ChampionshipMapper.Unmapper(model));
        }
    }
}
