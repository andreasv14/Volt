using DynamicData;
using System.Collections.Generic;
using System.Linq;
using Volt.Dtos;
using Volt.WebClientAPI;

namespace Volt.Mobile.Services
{
    public class CategoryService : ICategoryService
    {
        #region Private fields

        private readonly SourceCache<CategoryDto, int> _categoriesSource = new SourceCache<CategoryDto, int>(x => x.Id);
        private readonly ICategoryAPIService _categoryAPIService;
        private readonly List<CategoryDto> _allCategories;

        #endregion

        #region Constructors

        public CategoryService(ICategoryAPIService categoryAPIService)
        {
            _categoryAPIService = categoryAPIService;

            _allCategories = GetCategories();
            _categoriesSource.AddOrUpdate(_allCategories);
        }

        #endregion

        #region Observables

        public IObservableCache<CategoryDto, int> Categories => _categoriesSource.AsObservableCache();

        #endregion

        #region Public methods

        public void FilterCategories(string search)
        {
            _categoriesSource.Clear();

            var categories = new List<CategoryDto>();
            if (string.IsNullOrEmpty(search))
            {
                categories = _allCategories.ToList();
            }
            else
            {
                categories = _allCategories
                    .Where(c => c.Description.ToLower().Contains(search.ToLower())).ToList();
            }

            _categoriesSource.AddOrUpdate(categories);
        }

        #endregion

        #region Private methods

        private List<CategoryDto> GetCategories()
        {
            return _categoryAPIService.GetCategoriesAsync().GetAwaiter().GetResult().ToList();
        }

        #endregion
    }
}
