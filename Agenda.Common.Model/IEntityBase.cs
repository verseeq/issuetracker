using System;

namespace Agenda.Common.Model
{
    public interface IEntityBase
    {
        Guid Id { get; set; }
        EntityType Type { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
}