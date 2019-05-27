using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller 
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Here goes the description of this comic book!</p>";
            ViewBag.Artists = new string[]
                    {
                "Do: The First",
                "Re: The Second",
                "Mi: The Third",
                "Fa: The Fourth"
                    };

            return View();
            
        }
    }
}