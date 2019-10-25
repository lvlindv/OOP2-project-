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

        ///
        /// METHODS TO UPDATE CONTENT
        /// 

        /// <summary>
        /// Updates content of a given listbox
        /// </summary>
        /// <param name="lb">A listbox</param>
        /// <param name="objectList">A list of a type of object</param>
        public void UpdateListBox(ListBox lb, IEnumerable<object> objectList)
        {
            lb.Items.Clear();
            foreach (object o in objectList)
            {
                lb.Items.Add(o);
            }
        }

        /// <summary>
        /// Updates content of a given combobox
        /// </summary>
        /// <param name="lb">A combobox</param>
        /// <param name="objectList">A list of a type of object</param>
        public void UpdateComboBox(ComboBox cb, IEnumerable<object> objectList)
        {
            cb.Items.Clear();
            foreach (object o in objectList)
            {
                cb.Items.Add(o);
            }
        }

        ///
        /// BOOK TAB
        ///

        /// <summary>
        /// Method to show all authors to add a new book
        /// </summary>
        /// <param name="authors">A list of authors</param>
        public void BookTabShowAllAuthors(IEnumerable<Author> authors)
        {
            UpdateComboBox(comboBoxAuthor, authors);
        }

        /// <summary>
        /// Method to show books in the listbox in the books tab
        /// </summary>
        /// <param name="books">A list of books</param>
        private void ShowAllBooks(IEnumerable<Book> books)
        {
            UpdateListBox(lbBooks, books);
        }

        /// <summary>
        /// Method to show authors that the user can choose from to filter books
        /// </summary>
        /// <param name="authors">A list of authors</param>
        public void BookTabBooksByAuthor(IEnumerable<Author> authors)
        {
            UpdateComboBox(comboBoxBooksByAuthor, authors);
        }

        /// <summary>
        /// Button for showing books by selected author 
        /// </summary>
        private void btnBooksByAuthor_Click(object sender, EventArgs e)
        {
            UpdateListBox(lbBooks, bookService.GetAllBooksByAuthor((Author)comboBoxBooksByAuthor.SelectedItem));
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// "Show all books"-button
        /// </summary>
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

        /// <summary>
        /// "Add book"-button
        /// </summary>
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

        ///
        /// ADD NEW COPIES
        /// 

        /// <summary>
        /// Method to show books so that the user can pick one to add a copy of
        /// </summary>
        /// <param name="books">A list of books</param>
        public void ShowAllBooksInComboBox(IEnumerable<Book> books)
        {
            UpdateComboBox(comboBoxBook, books);
        }

        //Add new Copy-button
        private void button1_Click(object sender, EventArgs e)
        {
            BookCopy copy = new BookCopy((Book)comboBoxBook.SelectedItem, Convert.ToInt32(numericUpDownCopies.Value));
            bookCopyService.Add(copy);
            ShowAllBooks(bookService.All());
            LoanTabShowCopies(bookCopyService.All());
        }

        //
        // AUTHORS TAB
        //

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        public void AuthorTabShowAllAuthors(IEnumerable<Author> authors)
        {
            UpdateListBox(lbAuthors, authors);
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
        // MEMBERS TAB
        //

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        public void MemberTabShowAllMembers(IEnumerable<Member> members)
        {
            UpdateListBox(lbMembers, members);
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



        private void comboBoxBooksByAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        ///
        /// LOAN TAB
        ///

        public void ShowAllCurrentLoans(IEnumerable<Loan> loans)
        {
            UpdateListBox(lbCurrentLoans, loans);
        }

        /// <summary>
        /// Method to show members in the combobox for adding new loans
        /// </summary>
        /// <param name="members">A list of members</param>
        public void LoanTabShowMembers(IEnumerable<Member> members)
        {
            UpdateComboBox(comboBoxMembers, members);
        }

        /// <summary>
        /// Method to show book copies in the combobox for adding new loans
        /// </summary>
        /// <param name="copies">Takes a list of book copies</param>
        public void LoanTabShowCopies(IEnumerable<BookCopy> copies)
        {
            UpdateComboBox(comboBoxBookCopies, copies);
        }


        private void btnAddNewLoan_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan(dtLoans.Value.Date, (BookCopy)comboBoxBookCopies.SelectedItem, (Member)comboBoxMembers.SelectedItem);
            loanService.Add(loan);
            ShowAllCurrentLoans(loanService.GetAllCurrentLoans());
        }

        /// <summary>
        /// Method to show all previous loans
        /// </summary>
        /// <param name="loans">A list of loans</param>
        public void ShowAllReturnedLoans(IEnumerable<Loan> loans)
        {
            UpdateListBox(lbPreviousLoans, loans);
        }

        private void lbPreviousLoans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// "Return loan"-button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            UpdateComboBox(comboBoxLoansByMember, members);
        }

        /// <summary>
        /// Button to filter loans by entering a member
        /// </summary>
        private void btnShowLoansByMember_Click(object sender, EventArgs e)
        {
            UpdateListBox(lbOverdueLoans, loanService.GetAllOverdueLoansByMember((Member)comboBoxLoansByMember.SelectedItem));
            UpdateListBox(lbCurrentLoans, loanService.GetAllCurrentLoansByMember((Member)comboBoxLoansByMember.SelectedItem));
            UpdateListBox(lbPreviousLoans, loanService.GetAllPreviousLoansByMember((Member)comboBoxLoansByMember.SelectedItem));
        }



        private void comboBoxLoansByMember_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
