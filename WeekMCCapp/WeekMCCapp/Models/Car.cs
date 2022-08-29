using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WeekMCCapp.Models
{
	public class Car
	{
		[PrimaryKey, AutoIncrement]
		public string Id { get; set; }
		public string Merk { get; set; }
		public string Uitvoering { get; set; }
		public string Kenteken { get; set; }
		public string BrutoBPM { get; set; }
		public string Massa { get; set; }
		//Datum eerste toelating
		public string DET { get; set; }

		
	}
}
