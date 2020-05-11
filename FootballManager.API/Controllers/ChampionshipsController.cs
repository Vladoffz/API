using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ChampionshipsController : ControllerBase
    {

        private readonly IChampionshipService _championshipService;
        public ChampionshipsController(IChampionshipService championshipService)
        {
            _championshipService = championshipService;
        }


       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_championshipService.List());
        }


      
        [HttpPost]
        public IActionResult Post([FromBody] ChampionshipDTO model)
        {
            _championshipService.Insert(model);
            return Ok();
        }

       
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ChampionshipDTO model)
        {
            model.ID = id;
            _championshipService.Update(model);
            return Ok();
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _championshipService.DeleteEntity(id);
            return Ok();
        }
    }
}
