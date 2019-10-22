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
    public partial class AddBookForm : Form
    {

        public AddBookForm(BookService bookService, AuthorService authorService)
        {
            InitializeComponent();

            LibraryContext context = new LibraryContext();

            RepositoryFactory repFactory = new RepositoryFactory(context);

            bookService = new BookService(repFactory);
            authorService = new AuthorService(repFactory);

            ShowAllAuthors(authorService.All());
            
        }

        public void ShowAllAuthors(IEnumerable<Author> authors)
        {
            comboBoxAuthor.Items.Clear();
            foreach (Author author in authors)
            {
                comboBoxAuthor.Items.Add(author);
            }
        }


        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNrOfCopies_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (textBoxISBN.Text == "" || textBoxTitle.Text == "" || textBoxDescription.Text == "" || textBoxNrOfCopies.Text == "")
            {
                MessageBox.Show("", "You need to write something!");
            }
            else
            {
                // Lägg till i listan
                
                

                MessageBox.Show("You have now added the book: " + textBoxTitle.Text);
            }
        }
    }
}
