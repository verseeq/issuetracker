using System.ComponentModel.DataAnnotations;

namespace Agenda.IssueTracker.Api.Models
{
        public string Id { get; }
        public DateTime CreatedOn { get; }
        public DateTime? UpdatedOn { get; set; }
        public string DisplayName { get; set; }
        public Person Person { get; set; }
        public ICollection<ContactResource> Resources { get; set; } = new List<ContactResource>();
}