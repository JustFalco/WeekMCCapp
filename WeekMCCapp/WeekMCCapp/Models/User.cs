using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeekMCCapp.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public long UserId { get; set; }
        public string Name { get; set; }    

        public DateTime DOB { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public string Province { get; set; }
        public bool HasAutoIncasso { get; set; }

        
    }
}
