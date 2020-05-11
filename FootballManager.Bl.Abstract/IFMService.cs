using System;
using System.Collections.Generic;
using System.Text;
using FootballManager.DAL.Impl;
using FootballManager.Entities;
using Models;

namespace FootballManager.Bl.Abstract
{
    public interface IFMService
    {
        public List<ChampionshipCommandDTO> FindChampionshipCommand(int NumberOfChampionshipCommands);
        public List<PlayerDTO> FindPlayers(int NumberOfPlayers);
    }
}
