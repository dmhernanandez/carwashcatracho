using CarWashCatrachoHN.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarWashCatrachoHN.Views
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