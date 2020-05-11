using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using FootballManager.Entities;
using Models;

namespace FootballManager.DAL.Impl.Mappers
{
    public static class CommandMapper
    {
        public static CommandDTO Map(Command entity)
        {
            return new CommandDTO()
            {
                CommandID = entity.CommandID,
                Country = entity.Country,
                Name = entity.Name,
                PlayerID = entity.PlayerID
            };
        }
        public static Command Unmapper(CommandDTO model)
        {
            return new Command()
            {
                CommandID = model.CommandID,
                Country = model.Country,
                Name = model.Name,
                PlayerID = model.PlayerID
            };
        }
    }
}
