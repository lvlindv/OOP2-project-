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
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name og the author</param>
        public Author(string name)
        {
            this.Name = name;
            this.Books  = new List<Book>();
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Author()
        {
            this.Books = new List<Book>();

        }

        /// <summary>
        /// Useful for adding authour objects directly to a ListBox.
        /// </summary>
        /// <returns> Author object </returns>
        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }
    }
}
