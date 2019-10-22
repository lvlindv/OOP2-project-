using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {

        BookService bookService;
        AuthorService authorService;

        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);

            ShowAllAuthors(authorService.All());

        }

        //// Created a new list of books
        //public List<Book> bookList = new List<Book>();

        public void ShowAllAuthors(IEnumerable<Author> authors)
        {
            comboBoxAuthors.Items.Clear();
            foreach (Author author in authors)
            {
                comboBoxAuthors.Items.Add(author);
            }
        }

        private void ShowAllBooks(IEnumerable<Book> books)
        {
            //Code from project starting code

            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
            
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());
        }

        private void checkBoxOnlyAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Add new member
        private void BtnAddNewMember_Click(object sender, EventArgs e)
        {
            AddMemberForm AddMemberForm = new AddMemberForm();
            AddMemberForm.Show();
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        // Add new book
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddBookForm AddBookForm = new AddBookForm(bookService, authorService);
            AddBookForm.Show();
        }
    }
}
