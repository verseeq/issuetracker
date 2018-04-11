using System;
using System.Collections.Generic;

namespace Agenda.Common.Model
{
    public class Contact : IEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public EntityType Type { get; set; } = EntityType.Contact;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public string DisplayName { get; set; }
        public Person Person { get; set; }
        public ICollection<ContactResource> Resources { get; set; } = new List<ContactResource>();
    }
}