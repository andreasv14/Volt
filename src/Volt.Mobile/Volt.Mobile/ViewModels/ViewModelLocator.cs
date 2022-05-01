using Autofac;

namespace Volt.Mobile.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
        }

        public CompaniesViewModel CompaniesViewModel
        {
            get
            {
                return App.Container.Resolve<CompaniesViewModel>();
            }
        }
    }
}
