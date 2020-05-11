using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.Entities;
using Models;

namespace FootballManager.DAL.Impl.Mappers
{
    public static class MatchMapper
    {
        public static MatchDTO Map(Match entity)
        {
            return new MatchDTO()
            {
                MatchID = entity.MatchID,
                Date = entity.Date,
                Result = entity.Result,
                CommandID = entity.CommandID
            };
        }
        public static Match Unmapper(MatchDTO model)
        {
            return new Match()
            {
                MatchID = model.MatchID,
                Date = model.Date,
                Result = model.Result,
                CommandID = model.CommandID
            };
        }
    }
}
