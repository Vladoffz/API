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
    public class CommandService : CommandRepository, ICommandService
    {
        public CommandService(FootballManagerContext context) : base(context)
        {

        }

        public List<CommandDTO> FindByCountry(string Country)
        {
            return this.FindByCountryEntity(Country).Select(obj => CommandMapper.Map(obj)).ToList();
        }

        public List<CommandDTO> FindByName(string Name)
        {
            return this.FindByNameEntity(Name).Select(obj => CommandMapper.Map(obj)).ToList();
        }

        public CommandDTO Get(int CommandID)
        {
            return CommandMapper.Map(this.GetEntity(CommandID));
        }

        public void Insert(CommandDTO _Command)
        {
            this.InsertEntity(CommandMapper.Unmapper(_Command));
        }

        public List<CommandDTO> List()
        {
            return this.ListEntities().Select(obj => CommandMapper.Map(obj)).ToList();
        }

        public void Update(CommandDTO model)
        {
            this.UpdateEntity(CommandMapper.Unmapper(model));
        }
    }
}
