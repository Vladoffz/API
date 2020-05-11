using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.Entities;
using Models;

namespace FootballManager.DAL.Impl.Mappers
{
    public static class ChampionshipCommandMapper
    {
        public static ChampionshipCommandDTO Map(ChampionshipCommand entity)
        {
            return new ChampionshipCommandDTO()
            {
                ChampionshipCommandID = entity.ChampionshipCommandID,
                Name = entity.Name,
                ChampionshipID = entity.ChampionshipID,
                CommandID = entity.CommandID
            };
        }
        public static ChampionshipCommand Unmapper(ChampionshipCommandDTO model)
        {
            return new ChampionshipCommand()
            {
                ChampionshipCommandID = model.ChampionshipCommandID,
                Name = model.Name,
                ChampionshipID = model.ChampionshipID,
                CommandID = model.CommandID
            };
        }
    }
}
