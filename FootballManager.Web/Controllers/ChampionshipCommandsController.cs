using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager.Web.Controllers
{
    public class ChampionshipCommandsController : Controller
    {
        private readonly IChampionshipCommandService _ChampionshipCommandService;
        private readonly IFMService _FMService;

        public ChampionshipCommandsController(IChampionshipCommandService ChampionshipCommandService, IFMService FMService)
        {
            _ChampionshipCommandService = ChampionshipCommandService;
            _FMService = FMService;

        }
        public IActionResult Index(int NumberOfCommands)
        {
            if (NumberOfCommands != 0)
            {
                return View(_FMService.FindChampionshipCommand(NumberOfCommands));
            }

            else
            {
                return View(_ChampionshipCommandService.List());
            }
        }

        public IActionResult Update(int ID)
        {
            return View(_ChampionshipCommandService.Get(ID));
        }

        public IActionResult Create(int ID)
        {
            return View(_ChampionshipCommandService.Get(ID));
        }

        public IActionResult Delete(int ID)
        {
            return View(_ChampionshipCommandService.Get(ID));
        }
    }
}