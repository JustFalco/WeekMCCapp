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
		public ObservableCollection<Car> Cars { get; set; }
		
		public AboutViewModel()
        {
            Title = "Gegevens";
            Cars = new ObservableCollection<Car>();

            Cars.Add(new Car(
                    "Seat",
                    "Ibiza",
                    "43-LH-KL",
                    2300L,
                    1032L,
                    DateTime.Today
                ));

			Cars.Add(new Car(
					"Ford",
					"Mondeo",
					"17-TBZ-7",
					2540L,
					1250L,
					DateTime.Today
				));
		}
    }
}