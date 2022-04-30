using System.ComponentModel;
using Volt.Mobile.ViewModels;
using Xamarin.Forms;

namespace Volt.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}