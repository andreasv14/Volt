using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volt.Dtos;

namespace Volt.WebClientAPI
{
    public interface ICategoryAPIService
    {
        [Get("/categories")]
        public Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
    }
}
