using DynamicData;
using DynamicData.Binding;
using System;
using Volt.Dtos;
using Volt.Mobile.Infrastructure;
using Volt.Mobile.Services;

namespace Volt.Mobile.ViewModels
{
    public class CategoriesViewModel : BaseViewModel
    {
        private string _search;
        private readonly ICategoryService _categoryService;

        #region Constructors

        public CategoriesViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;

            categoryService
                .Categories
                .Connect()
                .Bind(Categories)
                .Subscribe();
        }

        #endregion

        #region Properties

        public string Search
        {
            get => _search;
            set
            {
                SetProperty(ref _search, value);
                FilterCategories();
            }
        }

        public ObservableCollectionExtended<CategoryDto> Categories { get; } = new ObservableCollectionExtended<CategoryDto>();

        #endregion

        #region Private methods

        private void FilterCategories()
        {
            _categoryService.FilterCategories(Search);
        }

        #endregion
    }
}
