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
        BookCopyService bookCopyService;
        AuthorService authorService;
        MemberService memberService;
        LoanService loanService;

        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.memberService = new MemberService(repFactory);
            this.loanService = new LoanService(repFactory);

            //Can we do this another way?
            ShowAllBooks(bookService.All());
            AuthorTabShowAllAuthors(authorService.All());
            BookTabShowAllAuthors(authorService.All());
            MemberTabShowAllMembers(memberService.All());
            BookTabBooksByAuthor(authorService.All());
            ShowAllBooksInComboBox(bookService.All());
            LoanTabShowMembers(memberService.All());
            LoanTabShowCopies(bookCopyService.All());
            ShowAllCurrentLoans(loanService.GetAllCurrentLoans());
            LoanTabShowLoansByMember(memberService.All());

        }

        //public void UpdateListBox (ListBox lb, IEnumerable<T> objectList)
        //{
        //    lb.Items.Clear();
        //    foreach (T o in objectList)
        //    {
        //        lb.Items.Add(o);
        //    }
        //}


        //public void UpdateComboBox(ComboBox cb, IEnumerable<T> objectList)
        //{
        //    cb.Items.Clear();
        //    foreach (T o in objectList)
        //    {
        //        cb.Items.Add(o);
        //    }
        //}


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
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }

            //UpdateListBox(lbBooks, IEnumerable < Book > books);
            
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
            if (textBoxISBN.Text == "" || textBoxTitle.Text == "" || textBoxDescription.Text == "" )
            {
                MessageBox.Show("", "You need to write something!");
            }
            else

            {
                var author = (Author)comboBoxAuthor.SelectedItem;
                Book book = new Book(textBoxISBN.Text, textBoxTitle.Text, textBoxDescription.Text, author);
                author.Books.Add(book);
                bookService.Add(book);

                MessageBox.Show("You have now added the book: " + textBoxTitle.Text);
                textBoxISBN.Clear();
                textBoxTitle.Clear();
                textBoxDescription.Clear();
                ShowAllBooks(bookService.All());
                ShowAllBooksInComboBox(bookService.All());
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
                BookTabBooksByAuthor(authorService.All());
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
                LoanTabShowMembers(memberService.All());
                LoanTabShowLoansByMember(memberService.All());
            }

        }

        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        //
        // List books by author
        //

        public void BookTabBooksByAuthor(IEnumerable<Author> authors)
        {
            comboBoxBooksByAuthor.Items.Clear();
            foreach (Author author in authors)
            {
                comboBoxBooksByAuthor.Items.Add(author);
            }
        }

        private void comboBoxBooksByAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBooksByAuthor_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            foreach (Book book in bookService.GetAllBooksByAuthor((Author)comboBoxBooksByAuthor.SelectedItem))
            {
                lbBooks.Items.Add(book);
            }
        }

        ///
        /// ADD NEW COPIES
        /// 
        public void ShowAllBooksInComboBox(IEnumerable<Book> books)
        {
            comboBoxBook.Items.Clear();
            foreach (Book book in books)
            {
                comboBoxBook.Items.Add(book);
            }
        }

        //Add new Copy-button
        private void button1_Click(object sender, EventArgs e)
        {
            BookCopy copy = new BookCopy((Book)comboBoxBook.SelectedItem, Convert.ToInt32(numericUpDownCopies.Value));
            bookCopyService.Add(copy);
            ShowAllBooks(bookService.All());
            LoanTabShowCopies(bookCopyService.All());
        }

        ///
        /// LOAN TAB
        ///

        public void ShowAllCurrentLoans(IEnumerable<Loan> loans)
        {
            lbCurrentLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbCurrentLoans.Items.Add(loan);
            }
        }

        /// <summary>
        /// Method to show members in the combobox for adding new loans
        /// </summary>
        /// <param name="members">A list of members</param>
        public void LoanTabShowMembers(IEnumerable<Member> members)
        {
            comboBoxMembers.Items.Clear();
            foreach (Member member in members)
            {
                comboBoxMembers.Items.Add(member);
            }
        }

        /// <summary>
        /// Method to show book copies in the combobox for adding new loans
        /// </summary>
        /// <param name="copies">Takes a list of book copies</param>
        public void LoanTabShowCopies(IEnumerable<BookCopy> copies)
        {
            comboBoxBookCopies.Items.Clear();
            foreach (BookCopy copy in copies)
            {
                comboBoxBookCopies.Items.Add(copy);
            }
        }


        private void btnAddNewLoan_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan(dtLoans.Value.Date, (BookCopy)comboBoxBookCopies.SelectedItem, (Member)comboBoxMembers.SelectedItem);
            loanService.Add(loan);
            ShowAllCurrentLoans(loanService.GetAllCurrentLoans());
        }

        //Knapp för att returnera böcker/lån
        public void ShowAllReturnedLoans(IEnumerable<Loan> loans)
        {
            lbPreviousLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbPreviousLoans.Items.Add(loan);
            }
        }

        private void lbPreviousLoans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            //try
            //{
                var selectedLoan = (Loan)lbCurrentLoans.SelectedItem;
                selectedLoan.TimeOfReturn = DateTime.Today;
                ShowAllReturnedLoans(loanService.GetAllPreviousLoans());
                ShowAllCurrentLoans(loanService.GetAllCurrentLoans());
            //}
            //catch
            //{
            //    new OperationCanceledException();
            //}


        }

        //
        // Show Loans by a specific member
        //

        /// <summary>
        /// Method to show members in the combobox for adding new loans
        /// </summary>
        /// <param name="members">A list of members</param>
        public void LoanTabShowLoansByMember(IEnumerable<Member> members)
        {
            comboBoxLoansByMember.Items.Clear();
            foreach (Member member in members)
            {
                comboBoxLoansByMember.Items.Add(member);
            }
        }

        private void btnShowLoansByMember_Click(object sender, EventArgs e)
        {
            lbOverdueLoans.Items.Clear();
            lbPreviousLoans.Items.Clear();
            lbCurrentLoans.Items.Clear();

            foreach (Loan loan in loanService.GetAllLoansByMember((Member)comboBoxLoansByMember.SelectedItem))
            {                  
                lbCurrentLoans.Items.Add(loan);
                lbPreviousLoans.Items.Add(loan);
                lbOverdueLoans.Items.Add(loan);
            }
        }



        private void comboBoxLoansByMember_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
