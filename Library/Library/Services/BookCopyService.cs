using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookCopyService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookCopyRepository bookCopyRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        /// <summary>
        ///  Method to get all book copies
        /// </summary>
        /// <returns>A list of copies</returns>
        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        /// <summary>
        /// A method to add a book copy to db
        /// </summary>
        /// <param name="copy">Takes a book copy object</param>
        public void Add(BookCopy copy)
        {
            bookCopyRepository.Add(copy);
            // TODO: Raise the Updated event.
        }

        /// <summary>
        /// The Edit method makes sure that the given Copy object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="a"></param>
        public void Edit(BookCopy c)
        {
            bookCopyRepository.Edit(c);
            // TODO: Raise the Updated event.
        }
    }
}
