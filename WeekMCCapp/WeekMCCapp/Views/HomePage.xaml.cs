using System.ComponentModel;
using WeekMCCapp.ViewModels;
using Xamarin.Forms;

namespace WeekMCCapp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
			InitializeComponent();
            this.BindingContext = new HomeViewModel();
		}
    }
}