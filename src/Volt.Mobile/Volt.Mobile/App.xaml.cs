using Autofac;
using Volt.Mobile.Services;
using Volt.Mobile.Services.Design;
using Volt.Mobile.Services.Interfaces;
using Volt.Mobile.ViewModels;
using Volt.WebClientAPI;
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
            // containerBuilder.Register(c => new CompanyServiceDesignData()).As<ICompanyService>();
            containerBuilder.Register(c => new CategoryServiceDesignData()).As<ICategoryAPIService>();
#else
            // Services 
            containerBuilder.RegisterType<ICategoryService>();
#endif

            containerBuilder.RegisterType<CategoryService>().As<ICategoryService>();

            // ViewModels
            //containerBuilder.RegisterType<ItemsViewModel>();
            containerBuilder.RegisterType<CompaniesViewModel>();
            containerBuilder.RegisterType<CategoriesViewModel>();

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
