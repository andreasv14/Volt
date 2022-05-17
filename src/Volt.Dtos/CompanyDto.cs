using System.Collections.Generic;

namespace Volt.Dtos
{
    public class CompanyDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

        public IEnumerable<ItemDto> Items { get; set; } = new List<ItemDto>();
    }
}
