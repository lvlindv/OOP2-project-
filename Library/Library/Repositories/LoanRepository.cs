using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class LoanRepository
    {
        /// <summary>
        /// Instantiates library context
        /// </summary>
        LibraryContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">A library context</param>
        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Method to get all loans from db
        /// </summary>
        /// <returns>A list of loans</returns>
        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        /// <summary>
        /// Method to add a loan to db
        /// </summary>
        /// <param name="loan">Takes a loan object</param>
        public void Add(Loan loan)
        {
            context.Loans.Add(loan);
            context.SaveChanges();
        }

        public void Edit(Loan l)
        {
            // Because the object l was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
        }
    }
}
