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

        //enum Availability { Available, Unavailable, Overdue };

        /// <summary>
        /// Constructor
        /// </summary>
        public BookCopy(Book Book, int Condition)
        {
            this.Book = Book;
            this.Condition = Condition;
            //string availability = (string)Availability.Available;
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public BookCopy()
        {

        }

        /// <summary>
        /// Useful for adding the copy objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1} by {2} -- Condition: {3}", this.CopyId, this.Book.Title, this.Book.Author, this.Condition);
        }
    }
}
