using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rFactory">A repository factory, so the service can create its own repository</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
        }


        /// <summary>
        /// Method to get all books
        /// </summary>
        /// <returns>A list of books</returns>
        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }


        /// <summary>
        /// Method to add books to db
        /// </summary>
        /// <param name="book"> Takes a book object</param>
        public void Add(Book book)
        {
            bookRepository.Add(book);
            // TODO: Raise the Updated event.
        }

        /// <summary>
        /// Method to get all books by a specific author
        /// </summary>
        /// <param name="author">Takes an author object</param>
        /// <returns>A list of books</returns>
        public IEnumerable<Book> GetAllBooksByAuthor(Author author)
        {
            return bookRepository.All().Where(b => b.Author == author); 
        }

        //public IEnumerable<Book> GetAllAvailableBooks()
        //{
        //    //return bookRepository.All().Where( b => )
        //}

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Book b)
        {
            bookRepository.Edit(b);
            // TODO: Raise the Updated event.
        }
    }
}
