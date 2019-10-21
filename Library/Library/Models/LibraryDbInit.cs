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
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            LibraryContext db = new LibraryContext();

            //Create author object
            Author alexDumas = new Author("Alexandre Dumas");

            //Create book object
            Book monteChristo = new Book("123", "The Count of Monte Christo", "A book about a count", alexDumas);

            // Add the book to the DbSet of books.
            db.Books.Add(monteChristo);

            // Persist changes to the database
            db.SaveChanges();
        }
    }
}
