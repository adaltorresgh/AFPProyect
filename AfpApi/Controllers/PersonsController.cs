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
    public class PersonsController : ControllerBase
    {
        PersonService personService;
        public PersonsController(ProjectDbContext context)
        {
            personService = new PersonService(context);
        }
        // GET: api/<GendersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(personService.Get());
        }


        // POST api/<GendersController>
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            _ = personService.Save(person);
            return Ok();
        }

        // PUT api/<GendersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person person)
        {
            _ = personService.Update(id, person);
            return Ok();
        }

        // DELETE api/<GendersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _ = personService.Delete(id);
            return Ok();
        }
    }
}
