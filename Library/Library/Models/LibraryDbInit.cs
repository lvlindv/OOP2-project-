using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {

        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            //LibraryContext db = new LibraryContext();

            ////Create author object
            //Author alexDumas = new Author()
            //{
            //    Name = "Alexandre Dumas"
            //};

            ////Create book object
            //Book monteChristo = new Book()
            //{
            //    ISBN = "123",
            //    Title = "The Count of Monte Christo",
            //    Description = "A book about a count",
            //    Author = alexDumas
            //};

            //// Add the book to the DbSet of books.
            //db.Books.Add(monteChristo);

            //// Persist changes to the database
            //db.SaveChanges();

            Book test = new Book()
            {
                Title = "testboken"
            };

            context.Books.Add(test);
            context.SaveChanges();

        }
    }
}
