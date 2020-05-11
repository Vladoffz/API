using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ChampionshipCommandsController : ControllerBase
    {

        private readonly IChampionshipCommandService _championshipCommandService;
        public ChampionshipCommandsController(IChampionshipCommandService championshipCommandService)
        {
            _championshipCommandService = championshipCommandService;
        }


        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_championshipCommandService.List());
        }


      
        [HttpPost]
        public IActionResult Post([FromBody] ChampionshipCommandDTO model)
        {
            _championshipCommandService.Insert(model);
            return Ok();
        }

       
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ChampionshipCommandDTO model)
        {
            model.ChampionshipCommandID = id;
            _championshipCommandService.Update(model);
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _championshipCommandService.DeleteEntity(id);
            return Ok();
        }
    }
}
