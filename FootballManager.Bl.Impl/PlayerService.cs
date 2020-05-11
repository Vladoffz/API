using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.Bl.Abstract;
using FootballManager.DAL.Impl;
using FootballManager.DAL.Impl.Mappers;
using FootballManager.Entities;
using Models;

namespace FootballManager.Bl.Impl
{
    public class PlayerService : PlayerRepository, IPlayerService
    {

        public PlayerService(FootballManagerContext context) : base(context)
        {

        }

        public List<PlayerDTO> List()
        {
            return this.ListEntities().Select(obj => PlayerMapper.Map(obj)).ToList();
        }

        public List<PlayerDTO> FindByFirstName(string FirstName)
        {
            return this.FindByFirstNameEntity(FirstName).Select(obj => PlayerMapper.Map(obj)).ToList();
        }
       public List<PlayerDTO> FindByAge(int Age)
       { 
           return this.FindByAgeEntity(Age).Select(obj => PlayerMapper.Map(obj)).ToList();
       }

        public void Insert(PlayerDTO _Player)
        {
            this.InsertEntity(PlayerMapper.Unmapper(_Player));
        }

        public PlayerDTO Get(int ID)
        {
            return PlayerMapper.Map(this.GetEntity(ID));
        }

        public void Update(PlayerDTO model)
        {
            this.UpdateEntity(PlayerMapper.Unmapper(model));
        }
    }
}
