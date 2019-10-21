using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Domain object "Author"
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Properties
        /// </summary>
        [Key]
        public int AuthorId { get; set; } //Primary key
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Author(string name)
        {
            //Set values of properties
            this.Name = name;
            List<Book> bookList = new List<Book>();
            this.Books = bookList;
        }

        public Author()
        {

        }
    }
}
