using Volt.Domain.Common;

namespace Volt.Domain.Entities
{
    public class Item : AuditableEntity
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }
    }
}