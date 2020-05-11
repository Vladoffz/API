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
    public class MatchesController : ControllerBase
    {

        private readonly IMatchService _matchService;
        public MatchesController(IMatchService matchService)
        {
            _matchService = matchService;
        }


       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_matchService.List());
        }


        
        [HttpPost]
        public IActionResult Post([FromBody] MatchDTO model)
        {
            _matchService.Insert(model);
            return Ok();
        }

       
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MatchDTO model)
        {
            model.MatchID = id;
            _matchService.Update(model);
            return Ok();
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _matchService.DeleteEntity(id);
            return Ok();
        }
    }
}
