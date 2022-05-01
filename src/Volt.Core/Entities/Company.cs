using System.Collections.Generic;
using Volt.Domain.Enums;

namespace Volt.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<CompanyCategory> Categories { get; } = new HashSet<CompanyCategory>();

        public ICollection<Item> Items { get; } = new HashSet<Item>();
    }
}