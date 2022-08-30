using System;
using System.Collections.Generic;
using System.Text;
using WeekMCCapp.Views;
using Xamarin.Forms;

namespace WeekMCCapp.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{
		public Command GegevensCommand { get; }
		public Command BetalingCommand { get; }
		public Command IncassoCommand { get; }
		public HomeViewModel()
		{
			Title = "Home";
			GegevensCommand = new Command(OnGegevensButtonClicked);
			BetalingCommand = new Command(OnBetalingButtonClicked);
			IncassoCommand = new Command(OnIncassoClicked);
		}

		private async void OnGegevensButtonClicked(object obj)
		{
			await Shell.Current.GoToAsync($"{nameof(GegevensPage)}");
		}
		private async void OnBetalingButtonClicked(object obj)
		{
			await Shell.Current.GoToAsync($"{nameof(BetalingPage)}");
		}
		private async void OnIncassoClicked(object obj)
		{
			await Shell.Current.GoToAsync($"{nameof(IncassoPage)}");
		}
	}
}
