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
    public class MatchService : MatchRepository, IMatchService
    {
        public MatchService(FootballManagerContext context) : base(context)
        {

        }

        public List<MatchDTO> FindByResult(int Result)
        {
            return this.FindByResultEntity(Result).Select(obj => MatchMapper.Map(obj)).ToList();
        }

        public MatchDTO Get(int MatchID)
        {
            return MatchMapper.Map(this.GetEntity(MatchID));
        }

        public void Insert(MatchDTO _Match)
        {
            this.InsertEntity(MatchMapper.Unmapper(_Match));
        }

        public List<MatchDTO> List()
        {
            return this.ListEntities().Select(obj => MatchMapper.Map(obj)).ToList();
        }

        public void Update(MatchDTO model)
        {
            this.UpdateEntity(MatchMapper.Unmapper(model));
        }
    }
}
