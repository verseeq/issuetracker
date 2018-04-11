using Agenda.Common.Model;

namespace Agenda.Common.Data
{
    public interface IPersonRepository : IEntityBaseRepository<Person> { }
    public interface IContactRepository : IEntityBaseRepository<Contact> { }
    public interface IContactResourceRepository : IEntityBaseRepository<ContactResource> { }
}