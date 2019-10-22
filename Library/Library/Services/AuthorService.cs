﻿using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        AuthorRepository authorRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }


        public IEnumerable<Author> GetAllThatContainsInName(string b)
        {
            return authorRepository.All().Where(a => a.Name.Contains(b));
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
