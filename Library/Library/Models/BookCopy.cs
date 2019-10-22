using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Domain object "Book Copy"
    /// </summary>
    public class BookCopy
    {
        /// <summary>
        /// Properties
        /// </summary>
        [Key]
        public int CopyId { get; set; }
        public virtual Book Book { get; set; }
        public int Condition { get; set; } //Can only be 1-10, implement rule

        /// <summary>
        /// Constructor
        /// </summary>
        public BookCopy(Book Book, int Condition)
        {
            this.Book = Book;
            this.Condition = Condition;
        }

        public BookCopy()
        {

        }
    }
}
