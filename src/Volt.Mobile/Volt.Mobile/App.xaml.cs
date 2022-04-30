using System;
using Volt.Mobile.Services;
using Volt.Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Volt.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
