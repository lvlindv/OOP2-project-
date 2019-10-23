using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class LoanService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        LoanRepository loanRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
        }

        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        public void Add(Loan loan)
        {
            loanRepository.Add(loan);
            // TODO: Raise the Updated event.
        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Loan l)
        {
            loanRepository.Edit(l);
            // TODO: Raise the Updated event.
        }
    }
}
