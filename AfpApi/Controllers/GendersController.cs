using BusinessModel.Services;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AfpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        GendersService gendersService;
        public GendersController(ProjectDbContext context)
        {
            gendersService = new GendersService(context);
        }
        // GET: api/<GendersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(gendersService.Get());
        }


        // POST api/<GendersController>
        [HttpPost]
        public IActionResult Post([FromBody] Genders genders)
        {
            _ = gendersService.Save(genders);
            return Ok();
        }

        // PUT api/<GendersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Genders genders)
        {
            _ = gendersService.Update(id, genders);
            return Ok();
        }

        // DELETE api/<GendersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _ = gendersService.Delete(id);
            return Ok();
        }
    }
}
