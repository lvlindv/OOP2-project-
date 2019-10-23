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

            //Create author /*object*/
            Author alexDumas = new Author()
            {
                Name = "Linda Petersson"
            };

            //Add the book to the DbSet of books.
            context.Authors.Add(alexDumas);

            //Persist changes to the database
            context.SaveChanges();

        }
    }
}
