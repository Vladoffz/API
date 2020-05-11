using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Abstract;
using Models;

namespace FootballManager.Bl.Abstract
{
    public interface IPlayerService : IRepositoryPlayer, IGenericService<PlayerDTO>
    {
        public List<PlayerDTO> List();
        public List<PlayerDTO> FindByFirstName(string FirstName);
        public void Insert(PlayerDTO _Player);
        public PlayerDTO Get(int ID);
        public void Update(PlayerDTO model);
    }
}
