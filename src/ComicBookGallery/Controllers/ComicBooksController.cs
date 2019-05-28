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
                DescriptionHtml = "<p>Final issue! Witnes the final hours of Doctor Octapus' life and his one, last, great act of revenge! even if Spider-Man survives,, .. will Peter Parker?.</p>",
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