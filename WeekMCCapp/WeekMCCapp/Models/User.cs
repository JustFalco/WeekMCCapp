using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeekMCCapp.Models
{
    internal class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string Name { get; set; }    

        public DateTime DOB { get; set; }

        public string address { get; set; }
        public string city { get; set; }
        public string postal { get; set; }
        public string province { get; set; }

    }
}
