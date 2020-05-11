using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.DAL.Abstract;
using FootballManager.Entities;

namespace FootballManager.DAL.Impl
{
    public class PlayerRepository : GenericRepository<Player>, IRepositoryPlayer
    {
        public PlayerRepository(FootballManagerContext context) : base(context)
        {

        }
        public IEnumerable<Player> FindByFirstNameEntity(string FirstName)
        {
            return this.ListEntities().Where(obj => obj.FirstName.Contains(FirstName));
        }
        public IEnumerable<Player> FindByAgeEntity(int Age)
        {
            return this.ListEntities().Where(obj => obj.Age.Equals(Age));
        }
    }
}
