namespace Volt.Domain.Common
{
    public abstract class AuditableEntity
    {
        public AuditableEntity()
        {
            Created = DateTime.Now;
            LastModified = DateTime.Now;
        }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? LastModified { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
