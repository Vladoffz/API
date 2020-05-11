/*using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using FootballManager.Bl.Abstract;
using FootballManager.DAL.Abstract;
using FootballManager.DAL.Impl;

namespace FootballManager.Bl.Impl
{
    public class ValidService : IValidService
    {
        private readonly ChampionshipCommandRepository _ChampionshipCommandRepository;
        private readonly PlayerRepository _PlayerRepository;

        public ValidService(ChampionshipCommandRepository ChampionshipCommandRepository, PlayerRepository PlayerRepository)
        {
            _ChampionshipCommandRepository = ChampionshipCommandRepository;
            _PlayerRepository = PlayerRepository;
        }

        public int VerifyPossibilityOfSettlement(int CommandID)
        {
            string FirstNameOfPlayer = _PlayerRepository.Get(CommandID).FirstName;
            int NumberOfCommands = _ChampionshipCommandRepository.List(obj => obj.CommandID == CommandID).Count();
            return CommandID;
        }
    }
}*/

