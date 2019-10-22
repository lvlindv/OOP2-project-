using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    /// <summary>
    /// Domain object "Book"
    /// </summary>
    public class Book {
        
        /// <summary>
        /// Properties
        /// </summary>
        
        [Key]
        public int BookId { get; set; } 
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Author Author { get; set; }
        // A book can have many copies, zero-to-many
        public virtual ICollection<BookCopy> BookCopies { get; set; }

        public Book(string ISBN, string Title, string Description, Author Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Description = Description;
            this.Author = Author;

            this.BookCopies = new List<BookCopy>();
        }

        public Book()
        {
            this.BookCopies = new List<BookCopy>();
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.BookId, this.ISBN, this.Title, this.Description);
        }
    }
}