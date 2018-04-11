using Agenda.Common.Model;

namespace Agenda.Common.Data
{
    public class ContactRepository : EntityBaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationContext context) : base(context) { }
    }
}