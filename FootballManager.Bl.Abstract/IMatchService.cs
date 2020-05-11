using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Abstract;
using Models;

namespace FootballManager.Bl.Abstract
{
   public  interface IMatchService : IRepositoryMatch, IGenericService<MatchDTO>
   {
       public List<MatchDTO> List();
       public List<MatchDTO> FindByResult(int Result);
       public void Insert(MatchDTO _Match);
       public MatchDTO Get(int MatchID);
       public void Update(MatchDTO model);
    }
}
