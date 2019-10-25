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

        /// <summary>
        /// Method to get all loans
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        /// <summary>
        /// Method to add loan to db
        /// </summary>
        /// <param name="loan">A loan object</param>
        public void Add(Loan loan)
        {
            loanRepository.Add(loan);
            // TODO: Raise the Updated event.
        }

        /// <summary>
        /// Method to get all current loans
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> GetAllCurrentLoans()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn == null);
        }

        /// <summary>
        /// Method to get all previous/returned loans
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> GetAllPreviousLoans()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn != null);
        }

        /// <summary>
        /// Method to get all overdue loans
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> GetAllOverdueLoans()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn == null && (l.DueDate - DateTime.Now).TotalDays < 0);
        }

        /// <summary>
        /// Method to get all loans by member
        /// </summary>
        /// <param name="member">A specific member in Member object</param>
        /// <returns>A list of loans by a specific member</returns>
        public IEnumerable<Loan> GetAllLoansByMember(Member member)
        {
            return loanRepository.All().Where(l => l.Member == member);
        }

        /// <summary>
        /// Method to get all current loans by a specific member
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> GetAllCurrentLoansByMember(Member member)
        {
            return loanRepository.All().Where(l => l.TimeOfReturn == null && l.Member == member);
        }

        /// <summary>
        /// Method to get all previous/returned loans by member
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> GetAllPreviousLoansByMember(Member member)
        {
            return loanRepository.All().Where(l => l.TimeOfReturn != null && l.Member == member);
        }

        /// <summary>
        /// Method to get all overdue loans
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> GetAllOverdueLoansByMember(Member member)
        {
            return loanRepository.All().Where(l => l.TimeOfReturn == null && (l.DueDate - DateTime.Now).TotalDays < 0 && l.Member == member);
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
