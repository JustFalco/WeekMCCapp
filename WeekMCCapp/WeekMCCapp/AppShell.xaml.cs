using System;
using System.Collections.Generic;
using WeekMCCapp.ViewModels;
using WeekMCCapp.Views;
using Xamarin.Forms;

namespace WeekMCCapp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
			Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
			Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
			Routing.RegisterRoute(nameof(GegevensPage), typeof(GegevensPage));
			Routing.RegisterRoute(nameof(BetalingPage), typeof(BetalingPage));
			Routing.RegisterRoute(nameof(IncassoPage), typeof(IncassoPage));
			Routing.RegisterRoute(nameof(CarSubmitPage), typeof(CarSubmitPage));
			Routing.RegisterRoute(nameof(FizzBuzzPage), typeof(FizzBuzzPage));
		}

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
