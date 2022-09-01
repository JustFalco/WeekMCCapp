using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WeekMCCapp.ViewModels
{
	public class CarSubmitViewModel : BaseViewModel
	{
		public Command SaveCarButtonCommand;
		public CarSubmitViewModel()
		{
			Title = "Auto toevoegen";
			SaveCarButtonCommand = new Command(SaveCar);
		}

		private void SaveCar(object obj)
		{
			if(string.IsNullOrWhiteSpace())
		}
	}
}
