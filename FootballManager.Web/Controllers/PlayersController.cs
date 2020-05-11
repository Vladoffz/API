using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager.Web.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayerService _PlayerService;
        private readonly IFMService _FMService;
        public PlayersController(IPlayerService PlayerService, IFMService FMService)
        {
            _PlayerService = PlayerService;
            _FMService = FMService;
        }

        public IActionResult Index(string FirstName)
        {

            if (!String.IsNullOrEmpty(FirstName))
            {
                return View(_PlayerService.FindByFirstName(FirstName));
            }
            else
            {
                return View(_PlayerService.List());
            }

        }

        public IActionResult Update(int ID)
        {
            return View(_PlayerService.Get(ID));
        }

        public IActionResult Delete(int ID)
        {
            return View(_PlayerService.Get(ID));
        }

        public IActionResult Create(int ID)
        {
            return View(_PlayerService.Get(ID));
        }
    }
}
