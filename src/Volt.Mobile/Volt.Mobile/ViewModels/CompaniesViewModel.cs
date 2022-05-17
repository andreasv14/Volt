using Volt.Mobile.Infrastructure;
using Volt.Mobile.Services.Interfaces;
using Xamarin.Forms;

namespace Volt.Mobile.ViewModels
{
    [QueryProperty(nameof(CategoryId), nameof(CategoryId))]
    public class CompaniesViewModel : BaseViewModel
    {
        private readonly ICategoryService categoryService;

        private int _categoryId;

        #region Constructors

        public CompaniesViewModel(
            ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        #endregion

        private string _title = string.Empty;

        public string Title
        {
            get => _title;
            private set => SetProperty(ref _title, value);
        }

        public int CategoryId
        {
            get => _categoryId;
            set
            {
                SetProperty(ref _categoryId, value);
                Title = categoryService.GetCategory(_categoryId).Description;
            }
        }
    }
}
