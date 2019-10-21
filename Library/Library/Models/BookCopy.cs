using System;
using System.Collections.Generic;
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
        public int CopyId { get; set; } //Primary key, when do we add?
        public Book Book { get; set; }
        public int Condition { get; set; } //Can only be 1-10, implement rule

        /// <summary>
        /// Constructor
        /// </summary>
        public BookCopy(Book Book, int Condition)
        {
            this.Book = Book;
            this.Condition = Condition;
        }
    }
}
