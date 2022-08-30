using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeekMCCapp.ViewModels;

namespace WeekMCCapp.Views
{
    public partial class GegevensPage : ContentPage
    {
        public GegevensPage()
        {
			InitializeComponent();
            this.BindingContext = new GegevensViewModel();
		}
    }
}