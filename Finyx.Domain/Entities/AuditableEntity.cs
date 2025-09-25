using System.ComponentModel.DataAnnotations;

namespace Finyx.Domain.Entities
{
    public abstract class AuditableEntity : BaseEntity
    {
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }
}
