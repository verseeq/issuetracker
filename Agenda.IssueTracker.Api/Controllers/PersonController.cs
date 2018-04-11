using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Agenda.Common.Data;
using Agenda.Common.Model;

namespace Agenda.Carisma.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

       // GET api/person
       [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(_personRepository.GetAll());
        }

        [HttpGet("{id}", Name = "GetPerson")]
        public IActionResult GetById(Guid id)
        {
            var item = _personRepository.GetBy(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}