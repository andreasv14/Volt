using DynamicData;
using Volt.Dtos;

namespace Volt.Mobile.Services
{
    public interface ICategoryService
    {
        IObservableCache<CategoryDto, int> Categories { get; }

        void FilterCategories(string search);
    }
}
