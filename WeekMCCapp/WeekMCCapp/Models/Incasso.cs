using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeekMCCapp.Models
{
	public class Incasso
	{
		[PrimaryKey, AutoIncrement]
		public long Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set;}
		public string Description { get; set; }
		public long BetalingsKenmerk { get; set; }
		
		public long UserId { get; set; }

		
	}
}
