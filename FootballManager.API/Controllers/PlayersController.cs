using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PlayersController : ControllerBase
    {

        private readonly IPlayerService _playerService;
        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }


     
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_playerService.List());
        }


      
        [HttpPost]
        public IActionResult Post([FromBody] PlayerDTO model)
        {
            _playerService.Insert(model);
            return Ok();
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PlayerDTO model)
        {
            model.ID = id;
            _playerService.Update(model);
            return Ok();
        }

     
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _playerService.DeleteEntity(id);
            return Ok();
        }
    }
}
