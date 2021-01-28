using SourceScout.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SourceScout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoverPage : ContentPage
    {
        private ContentViewModel viewmodel;

        public DiscoverPage()
        {
            InitializeComponent();

            viewmodel = new ContentViewModel();
            this.BindingContext = viewmodel;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
