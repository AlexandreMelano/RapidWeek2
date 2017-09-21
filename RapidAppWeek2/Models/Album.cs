using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RapidAppWeek2.Models
{
    public class Album
    {
        public string Title { get; set; }

        //Reference to Genre class and set up many to one relationship (many = genre)
        public Genre Genre { get; set; }
    }

}