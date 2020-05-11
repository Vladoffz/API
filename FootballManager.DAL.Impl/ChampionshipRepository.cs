using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.DAL.Abstract;
using FootballManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballManager.DAL.Impl
{
    public class ChampionshipRepository : GenericRepository<Championship>, IRepositoryChampionship
    {
        public ChampionshipRepository(FootballManagerContext context) : base(context)
        {

        }

        public IEnumerable<Championship> FindByNameEntity(string Name)
        {
            return this.ListEntities().Where(obj => obj.Name.Contains(Name));
        }
    }
}
