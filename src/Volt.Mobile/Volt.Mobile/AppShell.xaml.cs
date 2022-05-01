using System;
using System.Collections.Generic;
using Volt.Mobile.ViewModels;
using Volt.Mobile.Views;
using Xamarin.Forms;

namespace Volt.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
