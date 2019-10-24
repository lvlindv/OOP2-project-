using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Domain object "Loan"
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Properties
        /// </summary>
        [Key]
        public int LoanId { get; set; } 
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; } //Create method to check time of return VS due date
        public virtual BookCopy BookCopy { get; set; }
        public virtual Member Member { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="timeOfLoan"> set values of properties</param>
        /// <param name="bookCopy"></param>
        /// <param name="member"></param>
        public Loan(DateTime timeOfLoan, BookCopy bookCopy, Member member)
        {
            this.TimeOfLoan = timeOfLoan;
            this.DueDate = timeOfLoan.AddDays(15);
            this.BookCopy = bookCopy;
            this.Member = member;
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Loan()
        {

        }
    }
}
