using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WeekMCCapp.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WeekMCCapp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
		private ObservableCollection<Car> _cars;
		public ObservableCollection<Car> Cars
		{
			get
			{
				return _cars;
			}
			set
			{
				SetProperty(ref _cars, value);
				OnPropertyChanged("Products");
			}
		}
		public AboutViewModel()
        {
            Title = "Gegevens";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}