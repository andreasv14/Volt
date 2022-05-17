using Volt.Domain.Common;

namespace Volt.Domain.Entities;

public class Category : AuditableEntity
{
    public int Id { get; set; }

    public string Description { get; set; }
}
