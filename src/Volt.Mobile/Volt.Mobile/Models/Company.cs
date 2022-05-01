using System.Collections.Generic;

namespace Volt.Mobile.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Item> Items { get; } = new HashSet<Item>();
    }
}
