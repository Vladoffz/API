using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.DAL.Abstract;
using FootballManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballManager.DAL.Impl
{
    public class CommandRepository : GenericRepository<Command>, IRepositoryCommand
    {
        public CommandRepository(FootballManagerContext context) : base(context)
        {

        }

        public IEnumerable<Command> FindByCountryEntity(string Country)
        {
            return this.ListEntities().Where(obj => obj.Country.Contains(Country));
        }

        public IEnumerable<Command> FindByNameEntity(string Name)
        {
            return this.ListEntities().Where(obj => obj.Name.Contains(Name));
        }
    }
}
