using Autofac;
using Volt.Mobile.ViewModels;

namespace Volt.Mobile.Infrastructure
{
    public class ViewModelLocator
    {
        public CompaniesViewModel CompaniesViewModel
        {
            get
            {
                return App.Container.Resolve<CompaniesViewModel>();
            }
        }

        public CategoriesViewModel CategoriesViewModel
        {
            get
            {
                return App.Container.Resolve<CategoriesViewModel>();
            }
        }
    }
}