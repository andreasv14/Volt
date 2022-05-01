using System.Collections.ObjectModel;
using Volt.Mobile.Models;
using Volt.Mobile.Services.Interfaces;

namespace Volt.Mobile.ViewModels
{
    public class CompaniesViewModel : BaseViewModel
    {
        #region Constructors

        public CompaniesViewModel(
            ICompanyService companyService)
        {
            var x = companyService.GetItemsAsync().Result;

            Companies = new ObservableCollection<Company>(x);
        }

        #endregion

        #region Properties

        public ObservableCollection<Company> Companies { get; private set; }

        #endregion
    }
}
