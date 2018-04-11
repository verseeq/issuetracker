using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Agenda.Common.Data;
using Agenda.Common.Model;

namespace Agenda.Carisma.Controllers
{
    [Route("api/[controller]")]
    public class ContactResourceController : Controller
    {
        private readonly IContactResourceRepository _contactResourceRepository;

        public ContactResourceController(IContactResourceRepository contactResourceRepository)
        {
            _contactResourceRepository = contactResourceRepository;
        }

        // GET api/contactresource
        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(_contactResourceRepository.GetAll());
        }

        [HttpGet("{id}", Name = "GetContactResource")]
        public IActionResult GetById(Guid id)
        {
            var item = _contactResourceRepository.GetBy(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}