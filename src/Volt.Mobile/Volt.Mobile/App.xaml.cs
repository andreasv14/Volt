using Autofac;
using Volt.Mobile.Services.Design;
using Volt.Mobile.Services.Interfaces;
using Volt.Mobile.ViewModels;
using Xamarin.Forms;

namespace Volt.Mobile
{
    public partial class App : Application
    {
        public static IContainer Container;

        public App()
        {
            InitializeComponent();

            var containerBuilder = new ContainerBuilder();
#if DEBUG
            containerBuilder.Register(c => new CompanyServiceDesignData()).As<ICompanyService>();
            containerBuilder.Register(c => new ItemServiceDesignData()).As<IItemService>();
#else
            // Services 
           containerBuilder.Register(c => new CompanyService()).As<ICompanyService>();
           containerBuilder.Register(c => new ItemService()).As<IItemService>();
#endif

            // ViewModels
            containerBuilder.RegisterType<ItemsViewModel>();
            containerBuilder.RegisterType<CompaniesViewModel>();

            Container = containerBuilder.Build();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
