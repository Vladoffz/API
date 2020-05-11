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
    public class CommandsController : ControllerBase
    {

        private readonly ICommandService _commandService;
        public CommandsController(ICommandService CommandService)
        {
            _commandService = CommandService;
        }


       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_commandService.List());
        }


        
        [HttpPost]
        public IActionResult Post([FromBody] CommandDTO model)
        {
            _commandService.Insert(model);
            return Ok();
        }

      
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CommandDTO model)
        {
            model.CommandID = id;
            _commandService.Update(model);
            return Ok();
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _commandService.DeleteEntity(id);
            return Ok();
        }
    }
}
