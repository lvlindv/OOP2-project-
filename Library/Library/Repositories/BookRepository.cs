using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository : IRepository<Book, int>
    {
        /// <summary>
        /// Instantiates a library context
        /// </summary>
        LibraryContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">A library context</param>
        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Method to get all books from db
        /// </summary>
        /// <returns>A list of books</returns>
        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        /// <summary>
        /// Method to add books to db and save changes in the db
        /// </summary>
        /// <param name="book">A book object</param>
        public void Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Edit(Book b)
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }

        public void Remove(Book item)
        {
            throw new NotImplementedException();
        }

        public Book Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}