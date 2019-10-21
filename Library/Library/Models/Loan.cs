using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Loan
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int LoanId { get; set; } //Primary key
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime TimeOfReturn { get; set; } //Create method to check time of return VS due date
        public BookCopy BookCopy { get; set; }
        public Member Member { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Loan(DateTime timeOfLoan, BookCopy bookCopy, Member member)
        {
            //Set values of properties
            this.LoanId = 1; //Incrementation of Id?
            this.TimeOfLoan = timeOfLoan;
            this.DueDate = timeOfLoan.AddDays(15);
            this.BookCopy = bookCopy;
            this.Member = member;
        }
    }
}
