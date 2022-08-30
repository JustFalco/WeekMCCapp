using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using WeekMCCapp.Models;
using WeekMCCapp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeekMCCapp.Views
{
    public partial class FizzBuzzPage : ContentPage
    {
        public string FizzBuzz { get; set; }

        public FizzBuzzPage()
        {
			InitializeComponent();
            FizzBuzz = "test";
        }

		public void TextChanged(object sender, TextChangedEventArgs args)
		{
			string AwnserText = "It's ";
			Console.WriteLine(args.NewTextValue);

			try
			{
				if (Regex.IsMatch(args.NewTextValue, "[0-9]*"))
				{
					int number = int.Parse(args.NewTextValue);

					if (number % 3 == 0 && number % 5 == 0)
					{
						AwnserText += "FizzBuzz!";
					}
					else if (number % 3 == 0)
					{
						AwnserText += "Fizz!";
					}
					else if (number % 5 == 0)
					{
						AwnserText += "Buzz!";
					}
					else
					{
						AwnserText += args.NewTextValue;
					}
					Awnser.Text = AwnserText;
				}
			}catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}
	}
}