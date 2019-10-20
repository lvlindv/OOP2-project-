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
        public DateTime TimeOfReturn { get; set; }
        public BookCopy BookCopy { get; set; }
        public Member Member { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Loan()
        {
            //Set values of properties
        }
    }
}
