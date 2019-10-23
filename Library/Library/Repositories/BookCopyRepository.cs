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
        LibraryContext context;

        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        public void Add(BookCopy copy)
        {
            context.BookCopies.Add(copy);
            context.SaveChanges();
        }

        public void Edit(BookCopy c)
        {
            // Because the object c was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
        }
    }
}
