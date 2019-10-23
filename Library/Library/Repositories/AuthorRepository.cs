using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class AuthorRepository
    {
        /// <summary>
        /// Instatiates a library context
        /// </summary>
        LibraryContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">A library context</param>
        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Method to get all authors from database
        /// </summary>
        /// <returns>A list of authors</returns>
        public IEnumerable<Author> All()
        {
            return context.Authors;
        }

        /// <summary>
        /// Method to add author to db and save changes to db
        /// </summary>
        /// <param name="author">An author object</param>
        public void Add(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
        }

        // Edit function from Book
        public void Edit(Author a)
        {
            // Because the object a was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
        }
    }
}
