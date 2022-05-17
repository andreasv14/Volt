using DynamicData;
using Volt.Dtos;

namespace Volt.Mobile.Services.Interfaces
{
    public interface ICategoryService
    {
        IObservableCache<CategoryDto, int> Categories { get; }

        CategoryDto GetCategory(int categoryId);

        void FilterCategories(string search);
    }
}
