using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Abstract;
using Models;

namespace FootballManager.Bl.Abstract
{
    public interface ICommandService : IRepositoryCommand, IGenericService<CommandDTO>
    {
        public List<CommandDTO> List();
        public List<CommandDTO> FindByName(string Name);
        public List<CommandDTO> FindByCountry(string Country);
        public void Insert(CommandDTO _Command);
        public CommandDTO Get(int CommandID);
        public void Update(CommandDTO model);
    }
}
