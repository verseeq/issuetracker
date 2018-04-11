using Agenda.Common.Model;

namespace Agenda.Common.Data
{
    public class PersonRepository : EntityBaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationContext context) : base(context) { }
    }
}