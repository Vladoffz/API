using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.Entities;
using Models;

namespace FootballManager.DAL.Impl.Mappers
{
    public static class ChampionshipMapper
    {
        public static ChampionshipDTO Map(Championship entity)
        {
            return new ChampionshipDTO()
            {
                Name = entity.Name,
                ID = entity.ID
            };
        }
        public static Championship Unmapper(ChampionshipDTO model)
        {
            return new Championship()
            {
                ID = model.ID,
                Name = model.Name,
            };
        }
    }
}
