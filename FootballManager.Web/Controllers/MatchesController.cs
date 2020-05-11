using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using FootballManager.Bl.Impl;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager.Web.Controllers
{
    public class MatchesController : Controller
    {
        private readonly IMatchService _MatchService;
        private readonly IFMService _FMService;
        public MatchesController(IMatchService MatchService, IFMService FMService)
        {
            _MatchService = MatchService;
            _FMService = FMService;
        }

        public IActionResult Index(int Result)
        {
            //return View(_MatchService.FindByResult(Result));
            return View(_MatchService.List());
        }

        public IActionResult Create(int MatchID)
        {
            return View(_MatchService.Get(MatchID));
        }

        public IActionResult Delete(int MatchID)
        {
            return View(_MatchService.Get(MatchID));
        }

        public IActionResult Update(int MatchID)
        {
            return View(_MatchService.Get(MatchID));
        }
    }
}