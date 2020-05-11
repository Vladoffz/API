using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager.Web.Controllers
{
    public class CommandsController : Controller
    {
        private readonly ICommandService _CommandService;
        private readonly IFMService _FMService;
        public CommandsController(ICommandService CommandService, IFMService FMService)
        {
            _CommandService = CommandService;
            _FMService = FMService;
        }

        public IActionResult Index(string Name, string Country)
        {

            if (!String.IsNullOrEmpty(Name) || !String.IsNullOrEmpty(Country))
            {
                return View(_CommandService.FindByName(Name));
            }
            else
            {
                return View(_CommandService.List());
            }

        }

        public IActionResult Update(int CommandID)
        {
            return View(_CommandService.Get(CommandID));
        }

        public IActionResult Delete(int CommandID)
        {
            return View(_CommandService.Get(CommandID));
        }

        public IActionResult Create(int CommandID)
        {
            return View(_CommandService.Get(CommandID));
        }
    }
}
