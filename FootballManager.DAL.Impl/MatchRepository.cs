using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.DAL.Abstract;
using FootballManager.Entities;

namespace FootballManager.DAL.Impl
{
    public class MatchRepository : GenericRepository<Match>, IRepositoryMatch
    {
        public MatchRepository(FootballManagerContext context) : base(context)
        {

        }
        public IEnumerable<Match> FindByResultEntity(int Result)
        {
            return this.ListEntities().Where(obj => obj.Result.Equals(Result));
        }
    }
}
