using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.Entities;
using Models;

namespace FootballManager.DAL.Impl.Mappers
{
    public static class PlayerMapper
    {
        public static PlayerDTO Map(Player entity)
        {
            return new PlayerDTO()
            {
                ID = entity.ID,
                Age = entity.Age,
                Command = entity.Command,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
        public static Player Unmapper(PlayerDTO model)
        {
            return new Player()
            {
                ID = model.ID,
                Age = model.Age,
                Command = model.Command,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
        }

       
    }
}
