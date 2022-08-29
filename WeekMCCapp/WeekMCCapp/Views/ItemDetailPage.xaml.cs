using System.ComponentModel;
using WeekMCCapp.ViewModels;
using Xamarin.Forms;

namespace WeekMCCapp.Views
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