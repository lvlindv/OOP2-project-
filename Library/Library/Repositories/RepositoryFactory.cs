﻿using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class RepositoryFactory
    {
        private LibraryContext context;

        /// <param name="c">A Librarycontext that will be shared among repositories</param>
        public RepositoryFactory(LibraryContext c)
        {
            this.context = c;
        }

        public BookRepository CreateBookRepository()
        {
            return new BookRepository(context);
        }

        public AuthorRepository CreateAuthorRepository()
        {
            return new AuthorRepository(context);
        }

        public MemberRepository CreateMemberRepository()
        {
            return new MemberRepository(context);
        }

        public LoanRepository CreateLoanRepository()
        {
            return new LoanRepository(context);
        }

        public BookCopyRepository CreateBookCopyRepository()
        {
            return new BookCopyRepository(context);
        }
    }
}
