using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {
        
        /// <summary>
        /// Properties
        /// </summary>
        public int BookId { get; set; } //Primärnyckel, hur läggs den till?
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public IEnumerable<BookCopy> BookCopy { get; set; }

        public Book(string ISBN, string Title, string Description)
        {
            //Tilldela properties värden
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