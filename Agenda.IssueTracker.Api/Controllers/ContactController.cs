using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Agenda.Common.Data;
using Agenda.Common.Model;

namespace Agenda.Carisma.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactRepository _ContactRepository;

        public ContactController(IContactRepository ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }

        // GET api/Contact
        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(_ContactRepository.GetAll());
        }

        [HttpGet("{id}", Name = "GetContact")]
        public IActionResult GetById(Guid id)
        {
            var item = _ContactRepository.GetBy(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contact contact)
        {
            if (contact == null)
            {
                return BadRequest();
            }

            _ContactRepository.Add(contact);
            _ContactRepository.Commit();

            return CreatedAtRoute("GetContact", new { id = contact.Id}, contact);
        }
    }
}