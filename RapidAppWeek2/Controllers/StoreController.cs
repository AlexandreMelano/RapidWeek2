using RapidAppWeek2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapidAppWeek2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //create a typed list of Genres
            var genres = new List<Genre>();
            //create 10 genres in memory to pass to the main store view
            for(int i = 1; i <=10; i++)
            {   //This will loop and generate genre numbers like  genre1, genre2
                genres.Add(new Genre { name = "Genre" + i.ToString() });
            }//end of for loop

            //pass the typed list to the view for display
            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            ViewBag.Genre = genre;

            return View(); 
        }
    }
}