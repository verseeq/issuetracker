using System;

namespace Agenda.Common.Model
{
    public class ContactResource : IEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public EntityType Type { get; set; } = EntityType.ContactResource;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public ContactResourceType ResourceType { get; set; }
        public string Value { get; set; }
    }
}