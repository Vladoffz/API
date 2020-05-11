using FootballManager.Bl.Abstract;
using FootballManager.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.DAL.Impl.Mappers;
using Models;

namespace FootballManager.Bl.Impl
{
    public class ChampionshipCommandService : ChampionshipCommandRepository, IChampionshipCommandService
    {
        public ChampionshipCommandService(FootballManagerContext context) : base(context)
        {

        }
        public List<ChampionshipCommandDTO> List()
        {
            return this.ListEntities().Select(obj => ChampionshipCommandMapper.Map(obj)).ToList();
        }

        public void Insert(ChampionshipCommandDTO _ChampionshipCommand)
        {
            this.InsertEntity(ChampionshipCommandMapper.Unmapper(_ChampionshipCommand));
        }

        public ChampionshipCommandDTO Get(int ID)
        {
            return ChampionshipCommandMapper.Map(this.GetEntity(ID));
        }

        public void Update(ChampionshipCommandDTO model)
        {
            this.UpdateEntity(ChampionshipCommandMapper.Unmapper(model));
        }
    }
}
    

    
