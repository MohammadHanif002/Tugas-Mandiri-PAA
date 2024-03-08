using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace TugasMandiri.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static List<Person> persons = new List<Person>
        {
            new Person { Id = 1, Name = "Mamat Kabel", Age = 30 },
            new Person { Id = 2, Name = "Sigit Rawon", Age = 25 }
        };

        [HttpGet]
        public IActionResult Get([FromQuery] int id_person)
        {
            if (id_person != 0)
            {
                var person = persons.FirstOrDefault(p => p.Id == id_person);
                if (person != null)
                {
                    return Ok(person);
                }
                else
                {
                    return NotFound(new { message = "Person not found" });
                }
            }
            else
            {
                return BadRequest(new { message = "Please provide id_person parameter" });
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person newPerson)
        {
            if (newPerson != null)
            {
                persons.Add(newPerson);
                return CreatedAtAction(nameof(Get), new { id_person = newPerson.Id }, newPerson);
            }
            else
            {
                return BadRequest(new { message = "Invalid data provided" });
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
