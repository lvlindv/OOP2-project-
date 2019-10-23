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
        LibraryContext context;

        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

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
