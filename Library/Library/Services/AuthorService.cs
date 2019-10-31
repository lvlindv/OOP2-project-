using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class AuthorService : IService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        AuthorRepository authorRepository;

        public event EventHandler Updated;

        /// <summary>
        /// Method to check subscribers and raise Updated event
        /// </summary>
        /// <param name="e">An eventargs</param>
        protected virtual void OnUpdated(EventArgs e)
        {

            if (Updated != null)
            {
                Updated(this, e);
            }
        }

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        /// <summary>
        /// Method to get all authors
        /// </summary>
        /// <returns>A list of authors</returns>
        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        /// <summary>
        /// Method to add authors to db and call OnUpdated to raise Updated event
        /// </summary>
        /// <param name="author">Takes an author object</param>
        public void Add(Author author)
        {
            authorRepository.Add(author);
            OnUpdated(new EventArgs());        
        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="a"></param>
        public void Edit(Author a)
        {
            authorRepository.Edit(a);
            // TODO: Raise the Updated event.
        }
    }
}
