using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookCopyService : IService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookCopyRepository bookCopyRepository;

        public event EventHandler Updated;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        //Metod där Due date
        //Join

        //Available books
        //Hämta alla aktiva lån --> ett lån med ett due date (due date != null) och ingen time of return (time of return == null)
        //Hämta alla bookcopies som inte är kopplat till ett aktivt lån
        //--> Hämta alla böcker kopplat till ovan lista av bookcopies/Alla bookcopy-Titlar?



        public IEnumerable<BookCopy> GetAvailableBookCopies(IEnumerable<BookCopy> copyList, IEnumerable<Loan> allLoans)
        {
            //var activeLoans = loanList.Where(l => l.DueDate != null && l.TimeOfReturn == null); //Alla aktiva lån

            var result1 = copyList.Where(copy => !allLoans.Any(loan => loan.BookCopy.CopyId == copy.CopyId)); //Alla böcker som inte är kopplade till något lån (aldrig har blivit lånade)

            var result2 = copyList.Where(copy => allLoans.Any(loan => loan.BookCopy.CopyId == copy.CopyId && loan.TimeOfReturn != null)); //Alla böcker som har blivit utlånade MEN returnerats

            var availableCopies = result1.Concat(result2).ToList();

            return availableCopies;
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
