using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager.Web.Controllers
{
    public class ChampionshipsController : Controller
    {
        private readonly IChampionshipService _ChampionshipService;
        private readonly IFMService _FMService;
        public ChampionshipsController(IChampionshipService ChampionshipService, IFMService FMService)
        {
            _ChampionshipService = ChampionshipService;
            _FMService = FMService;
        }

        public IActionResult Index(string Name)
        {

            if (!String.IsNullOrEmpty(Name))
            {
                return View(_ChampionshipService.FindByName(Name));
            }
            else
            {
                return View(_ChampionshipService.List());
            }

        }

        public IActionResult Update(int ID)
        {
            return View(_ChampionshipService.Get(ID));
        }

        public IActionResult Delete(int ID)
        {
            return View(_ChampionshipService.Get(ID));
        }

        public IActionResult Create(int ID)
        {
            return View(_ChampionshipService.Get(ID));
        }
    }
}