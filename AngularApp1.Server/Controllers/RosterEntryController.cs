using AngularApp1.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AngularApp1.Server.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RosterEntryController : ControllerBase
    {
        private readonly IRosterEntryRepository _rosterEntryRepository;

        public RosterEntryController(IRosterEntryRepository rosterEntryRepository)
        {
            _rosterEntryRepository = rosterEntryRepository;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            var entries = _rosterEntryRepository.GetAll();
            return Ok(entries);

        }

        // GET api/<ValuesController>/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var entry = _rosterEntryRepository.GetById(id);
            return Ok(entry);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] RosterEntry rosterEntry)
        {
            if (id != rosterEntry.Id)
            {
                return BadRequest();
            }

            _rosterEntryRepository.UpdateRosterEntry(rosterEntry);
            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}
