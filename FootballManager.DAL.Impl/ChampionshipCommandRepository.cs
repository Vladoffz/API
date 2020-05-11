using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.DAL.Abstract;
using FootballManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballManager.DAL.Impl
{
    public class ChampionshipCommandRepository : GenericRepository<ChampionshipCommand>, IRepositoryChampionshipCommand
    {
        public ChampionshipCommandRepository(FootballManagerContext context) : base(context)
        {

        }
        public IEnumerable<ChampionshipCommand> FindByNameEntity(string Name)
        {
            return this.ListEntities().Where(obj => obj.Name.Contains(Name));
        }

        public List<ChampionshipCommand> GetListDownToTheRoot()
        {
            return this._DBContext.Set<ChampionshipCommand>().Include(obj => obj.Championships).ToList();
        }
        
    }
}
