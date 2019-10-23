﻿using Library.Models;
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
        MemberService memberService;

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
            this.memberService = new MemberService(repFactory);

            AuthorTabShowAllAuthors(authorService.All());
            BookTabShowAllAuthors(authorService.All());
            MemberTabShowAllMembers(memberService.All());

        }

        public void BookTabShowAllAuthors(IEnumerable<Author> authors)
        {
            comboBoxAuthor.Items.Clear();
            foreach (Author author in authors)
            {
                comboBoxAuthor.Items.Add(author);
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


        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //
        // ADD NEW BOOK
        //
        private void tabPage1_Click(object sender, EventArgs e)
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

        private void textBoxCopies_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            //AddBookForm AddBookForm = new AddBookForm(bookService, authorService);
            //AddBookForm.Show();

            if (textBoxISBN.Text == "" || textBoxTitle.Text == "" || textBoxDescription.Text == "" )
            {
                MessageBox.Show("", "You need to write something!");
            }
            else

            {
                var author = (Author)comboBoxAuthor.SelectedItem;
                Book book = new Book(textBoxISBN.Text, textBoxTitle.Text, textBoxDescription.Text, author);
                BookCopy bookCopy = new BookCopy(book, 10);
                book.BookCopies.Add(bookCopy);
                author.Books.Add(book);
                bookService.Add(book);

                MessageBox.Show("You have now added the book: " + textBoxTitle.Text);
                textBoxISBN.Clear();
                textBoxTitle.Clear();
                textBoxDescription.Clear();
                ShowAllBooks(bookService.All());
            }
        }

        //
        // ADD NEW AUTHOR
        //

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        public void AuthorTabShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthors.Items.Add(author);
            }
        }

        private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {

            if (textBoxAuthorName.Text == "")
            {
                MessageBox.Show("", "You need to write something!");
            }
            else
            {
                Author author = new Author(textBoxAuthorName.Text);
                authorService.Add(author);

                MessageBox.Show("You have now added the author: " + textBoxAuthorName.Text);
                textBoxAuthorName.Clear();
                AuthorTabShowAllAuthors(authorService.All());
                BookTabShowAllAuthors(authorService.All());
            }
        }

        //
        // ADD NEW MEMBER
        //

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public void MemberTabShowAllMembers(IEnumerable<Member> members)
        {
            lbMembers.Items.Clear();
            foreach (Member member in members)
            {
                lbMembers.Items.Add(member);
            }
        }

        private void textBoxMemberPersonalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddNewMember_Click(object sender, EventArgs e)
        {
            //AddMemberForm AddMemberForm = new AddMemberForm();
            //AddMemberForm.Show();

            if (textBoxMemberName.Text == "" || textBoxMemberPersonalID.Text == "")
            {
                MessageBox.Show("", "You need to write something!");
            }
            else
            {
                DateTime createdDate = DateTime.Today;
                Member member = new Member(Convert.ToInt32(textBoxMemberPersonalID.Text), textBoxMemberName.Text, createdDate);
                memberService.Add(member);

                MessageBox.Show("You have now added the member: " + textBoxMemberName.Text);
                textBoxMemberName.Clear();
                textBoxMemberPersonalID.Clear();
                MemberTabShowAllMembers(memberService.All());
            }

        }

        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
