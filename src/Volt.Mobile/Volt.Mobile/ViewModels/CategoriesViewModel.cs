using DynamicData;
using DynamicData.Binding;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Volt.Dtos;
using Volt.Mobile.Infrastructure;
using Volt.Mobile.Services;
using Xamarin.Forms;

namespace Volt.Mobile.ViewModels
{
    public class CategoriesViewModel : BaseViewModel
    {
        #region Private fields

        private readonly ICategoryService _categoryService;

        private string _search;
        private CategoryDto _selectedCategory;

        #endregion

        #region Constructors

        public CategoriesViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;

            categoryService
                .Categories
                .Connect()
                .Bind(Categories)
                .Subscribe();

            SelectCategoryCommand = new Command(OnSelectCategoryCommand);
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
        public CategoryDto SelectedCategory
        {
            get => _selectedCategory;
            set => SetProperty(ref _selectedCategory, value);
        }

        public ObservableCollectionExtended<CategoryDto> Categories { get; } = new ObservableCollectionExtended<CategoryDto>();

        public ICommand SelectCategoryCommand { get; }

        #endregion

        #region Private methods

        private void FilterCategories()
        {
            _categoryService.FilterCategories(Search);
        }

        private async void OnSelectCategoryCommand(object obj)
        {
            await Shell.Current.GoToAsync($"CompaniesPage?CategoryId={SelectedCategory.Id}");
        }

        #endregion
    }
}
