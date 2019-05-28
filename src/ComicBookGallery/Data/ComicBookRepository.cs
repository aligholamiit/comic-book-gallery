using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;


    public class ComicBookRepository
    {
    private static ComicBook[] _comicBooks = new ComicBook[]
            {
                new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man 1",
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
            },
                new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man 2",
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
            },
                new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man 3",
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
            }
            };
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
        foreach (var comicBook in _comicBooks)
        {
            if (comicBook.Id == id)
            {
                comicBookToReturn = comicBook;
                break;
            }
        }
            return comicBookToReturn;
        }
    }
