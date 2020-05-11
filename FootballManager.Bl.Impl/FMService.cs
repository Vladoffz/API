using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballManager.DAL.Impl;
using FootballManager.Bl.Abstract;
using FootballManager.DAL.Abstract;
using FootballManager.DAL.Impl.Mappers;
using FootballManager.Entities;
using Models;

namespace FootballManager.Bl.Impl
{
    public class FMService : IFMService
    {
        private readonly IRepositoryPlayer _PlayerRepository;
        private readonly IRepositoryChampionshipCommand _ChampionshipCommandRepository;

        public FMService(IRepositoryPlayer PlayerRepository, IRepositoryChampionshipCommand ChampionshipCommandRepository)
        {
            _PlayerRepository = PlayerRepository;
            _ChampionshipCommandRepository = ChampionshipCommandRepository;
        }
        List<ChampionshipCommandDTO> IFMService.FindChampionshipCommand(int NumberOfChampionshipCommands)
        {
            List<ChampionshipCommand> ChampionshipCommands = new List<ChampionshipCommand>();

            foreach (ChampionshipCommand C in _ChampionshipCommandRepository.GetListDownToTheRoot())
            {
                int NumberOfChampionshipCommandsIT = 0;
                foreach (Championship Co in C.Championships)
                {
                    foreach (Command B in C.Commands)
                    {
                        foreach (Player P in B.Players)
                        {
                            NumberOfChampionshipCommandsIT += _PlayerRepository.ListEntities().Where(obj => obj.ID == P.ID).Count();
                        }
                    }
                }
                if (NumberOfChampionshipCommandsIT == NumberOfChampionshipCommands)
                {
                    ChampionshipCommands.Add(C);
                }
            }
            return ChampionshipCommands.Select(obj => ChampionshipCommandMapper.Map(obj)).ToList();
        }

        List<PlayerDTO> IFMService.FindPlayers(int NumberOfPlayers)
        {
            List<Player> Players = new List<Player>();
            foreach (Player P in _PlayerRepository.ListEntities())
            {
                if (_PlayerRepository.ListEntities(obj => obj.ID == P.ID).Count() == NumberOfPlayers) { Players.Add(P); }
            }
            return Players.Select(obj => PlayerMapper.Map(obj)).ToList();
        }
    }
}
