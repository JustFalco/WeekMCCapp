using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using WeekMCCapp.Models;
using WeekMCCapp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WeekMCCapp.ViewModels
{
    public class GegevensViewModel : BaseViewModel
    {
        public Command AddCarCommand { get; }
		public ObservableCollection<Car> Cars { get; set; }
		public ObservableCollection<User> Users { get; set; }
		public GegevensViewModel()
        {
            Title = "Gegevens";

            Cars = new ObservableCollection<Car>();
            Users = new ObservableCollection<User>();

            AddCarCommand = new Command(OnAddCarButtonClicked);

            Users.Add(NewUser());
            Cars.Add(NewCar1());
		}

		/*public async Task GetData()
        {
            Users.Add(await Database.GetUserFromDatabase());
        }*/

		private async void OnAddCarButtonClicked(object obj)
		{
			await Shell.Current.GoToAsync($"{nameof(CarSubmitPage)}");
		}

		//Niet de beste oplossing, maar tijdelijk kan het wel even
		//TODO Fix dit
		private Car NewCar1()
        {
            Car car = new Car();
            car.Merk = "Seat";
            car.Uitvoering = "Ibiza";
            car.Kenteken = "43-LH-KL";
            car.Massa = 2300L;
            car.BrutoBPM = 1032L;
            car.DET = DateTime.Today;

            return car;
        }

        private User NewUser()
        {
            User user = new User
            {
                Name = "Falco Wolkorte"
            };

            return user;
        }
    }
}