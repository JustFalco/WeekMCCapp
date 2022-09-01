using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WeekMCCapp.Models
{
	public class Car
	{
		[PrimaryKey, AutoIncrement]
		public long CarId { get; set; }
		public string Merk { get; set; }
		public string Uitvoering { get; set; }
		public string Kenteken { get; set; }
		public long BrutoBPM { get; set; }
		public long Massa { get; set; }
		//Datum eerste toelating
		public DateTime DET { get; set; }

		
	}
}
