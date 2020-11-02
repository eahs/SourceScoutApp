using System.ComponentModel;
using Xamarin.Forms;
using SourceScout.ViewModels;

namespace SourceScout.Views
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