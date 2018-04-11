using Agenda.Common.Model;

namespace Agenda.Common.Data
{
    public class ContactResourceRepository : EntityBaseRepository<ContactResource>, IContactResourceRepository
    {
        public ContactResourceRepository(ApplicationContext context) : base(context) { }
    }
}