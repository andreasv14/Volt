using Volt.Mobile.Infrastructure;
using Xamarin.Forms;

namespace Volt.Mobile.ViewModels
{
    [QueryProperty(nameof(CategoryId), nameof(CategoryId))]
    public class CompaniesViewModel : BaseViewModel
    {
        #region Constructors

        public CompaniesViewModel()
        {
        }

        #endregion

        private int _categoryId;
        public int CategoryId
        {
            get => _categoryId;
            set => SetProperty(ref _categoryId, value);
        }
    }
}
