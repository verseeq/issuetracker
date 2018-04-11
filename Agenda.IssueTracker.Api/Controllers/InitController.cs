using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Agenda.Common.Data;
using Agenda.Common.Model;

namespace Agenda.IssueTracker.Api.Controllers
{
    [Route("api/[controller]")]
    public class InitController : Controller
    {
        private readonly IPersonRepository _personRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IContactResourceRepository _contactResourceRepository;

        public InitController(IPersonRepository personRepository, IContactRepository contactRepository, IContactResourceRepository contactResourceRepository)
        {
            _personRepository = personRepository;
            _contactRepository = contactRepository;
            _contactResourceRepository = contactResourceRepository;
        }

        // GET api/init
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _personRepository.Add(new Person { FirstName = "Станислав", MiddleName = "Анатольевич", LastName = "Рагозин", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Константин", MiddleName = "Андреевич", LastName = "Брикалов", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Виктор", MiddleName = "Сергеевич", LastName = "Афанасьев", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Антон", MiddleName = "Владимирович", LastName = "Черненок", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Алексей", MiddleName = "Олегович", LastName = "Федотов", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Владислав", MiddleName = "Викторович", LastName = "Рагозин", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Игорь", MiddleName = "Владиславович", LastName = "Богданов", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Наталья", MiddleName = "Олеговна", LastName = "Самохвалова", Gender = Gender.Female });
            _personRepository.Add(new Person { FirstName = "Анна", MiddleName = "Станиславовна", LastName = "Рагозина", Gender = Gender.Female });
            _personRepository.Add(new Person { FirstName = "Ирина", MiddleName = "Анасовна", LastName = "Мухаметова", Gender = Gender.Female });
            _personRepository.Add(new Person { FirstName = "John", LastName = "Doe" });
            _personRepository.Add(new Person { FirstName = "David", LastName = "Lynch", Gender = Gender.Male });
            _personRepository.Add(new Person { FirstName = "Judy" });
            _personRepository.Commit();
            var message = new[] { new { message = "Initialisation of Person repository done." } };

            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Location | ContactResourceType.Legal | ContactResourceType.Home, Value = "ул. Университетская, д. 11, кв. 89 г. Сургут, Тюменская область, Россия, 628402" });
            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Location |ContactResourceType.Shipping | ContactResourceType.Default, Value = "11407 SW AMU ST STE 68056, SUITE #407, TUALATIN, OR, UNITED STATES, 97062-6884" });
            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Telephone | ContactResourceType.Mobile | ContactResourceType.Default, Value = "+7 922 6599584" });
            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Telephone | ContactResourceType.Home, Value = "+7 3462 567000" });
            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Telephone | ContactResourceType.Business, Value = "+7 495 9802800 ext. 6023" });
            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Telephone | ContactResourceType.Mobile, Value = "+7 912 8118271" });
            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Telephone | ContactResourceType.Mobile | ContactResourceType.Default, Value = "+7 922 4325432" });
            _contactResourceRepository.Add(new ContactResource { ResourceType = ContactResourceType.Telephone | ContactResourceType.Business | ContactResourceType.Default, Value = "+7 495 9802800 ext. 6055" });
            _contactResourceRepository.Commit();
            message.Append( new { message = "Initialisation of ContactResource repository done." } );

            foreach (var person in _personRepository.GetAll())
            {
                _contactRepository.Add(new Contact { DisplayName = $"{person.FirstName} {person.LastName}", Person = person });
                _contactResourceRepository.Commit();
            }
            message.Append( new { message = "Initialisation of Contact repository done." } );

            return new string[] { "Initialization", "Done" };
        }
    }
}
