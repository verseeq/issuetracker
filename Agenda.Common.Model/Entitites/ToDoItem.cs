using System;

namespace Agenda.Common.Model
{
    public class ToDoItem : IEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public EntityType Type { get; set; } = EntityType.ToDoItem;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedOn { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public bool Done { get; set; }
    }
}
