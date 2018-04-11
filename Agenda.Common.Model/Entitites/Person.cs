using System;

namespace Agenda.Common.Model
{
    public class Person : IEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public EntityType Type { get; set; } = EntityType.Person;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }
    }
}