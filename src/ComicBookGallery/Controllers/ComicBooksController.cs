using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Here goes the description of this comic book!</p>",
                Artists = new Artist[]
                    {
                        new Artist() {Role="Script", Name="Dan Slott"},
                        new Artist() {Role="Pencils", Name="Humbrto Ramos"},
                        new Artist() {Role="Inks", Name="Victor Olazaba"},
                        new Artist() {Role="Colors", Name="Edgar Delgado"},
                        new Artist() {Role="Letters", Name="Elio Poulos"},
                    }
            };

            return View(comicBook);
            
        }
    }
}