using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class BookCopyRepository
    {
        /// <summary>
        /// Instantiates a library context
        /// </summary>
        LibraryContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">A library context</param>
        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Method to get all book copies from db
        /// </summary>
        /// <returns>A list of book copies</returns>
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        /// <summary>
        /// Method to add book copy to db and save changes in the db
        /// </summary>
        /// <param name="copy">Takes a book copy object</param>
        public void Add(BookCopy copy)
        {
            context.BookCopies.Add(copy);
            context.SaveChanges();
        }

        // fråga
        public void Edit(BookCopy c)
        {
            // Because the object c was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
        }
    }
}
