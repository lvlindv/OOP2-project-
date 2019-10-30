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
        /// <summary>
        /// 
        /// </summary>
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
            LoanTabShowCopies(bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));
            ShowAllLoans(loanService.GetAllCurrentLoans(), loanService.GetAllPreviousLoans(), loanService.GetAllOverdueLoans());
            LoanTabShowLoansByMember(memberService.All());

            TEST(loanService.All(), bookCopyService.All());

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







        //----------------------------------------------------------------------------------------------------------------------------
        // BOOK TAB
        //----------------------------------------------------------------------------------------------------------------------------

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

        /// <summary>
        /// "Add book"-button
        /// </summary>
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (textBoxISBN.Text == "" || textBoxTitle.Text == "" || textBoxDescription.Text == "" || (Author)comboBoxAuthor.SelectedItem == null)
            {
                MessageBox.Show("You need to fill in all book details.", "Error!");
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

        /// <summary>
        /// "Show all books"-button
        /// </summary>
        private void btnShowAllBooks_Click_1(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());
        }



        ///-----------------
        /// ADD NEW COPIES
        /// ----------------


        /// <summary>
        /// Method to show books so that the user can pick one to add a copy of
        /// </summary>
        /// <param name="books">A list of books</param>
        public void ShowAllBooksInComboBox(IEnumerable<Book> books)
        {
            UpdateComboBox(comboBoxBook, books);
        }

        /// <summary>
        /// "Add new copy"-button
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if((Book)comboBoxBook.SelectedItem != null)
            {
                try
                {
                    BookCopy copy = new BookCopy((Book)comboBoxBook.SelectedItem, Convert.ToInt32(numericUpDownCopies.Value));
                    bookCopyService.Add(copy);
                    ShowAllBooks(bookService.All());
                    LoanTabShowCopies(bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));
                    TEST(loanService.All(), bookCopyService.All());
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Value can not be null.", "ArgumentNullException");
                }
            }
            else
            {
                MessageBox.Show("You need to choose a book.", "Error!");
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------
        // AUTHORS TAB
        //----------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Updates the listbox with all authors
        /// </summary>
        /// <param name="authors">A list of authors</param>
        public void AuthorTabShowAllAuthors(IEnumerable<Author> authors)
        {
            UpdateListBox(lbAuthors, authors);
        }


        /// <summary>
        /// "Add new author"-knapp
        /// </summary>
         private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {

            if (textBoxAuthorName.Text == "")
            {
                MessageBox.Show("You need to enter a name of the author.", "Error!");
            }
            else if (!textBoxAuthorName.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name can only contain letters.", "Error!");
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

                                                   
        //----------------------------------------------------------------------------------------------------------------------------
        // MEMBERS TAB
        //----------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Updates listbox with all members
        /// </summary>
        /// <param name="members">A list of members</param>
        public void MemberTabShowAllMembers(IEnumerable<Member> members)
        {
            UpdateListBox(lbMembers, members);

        }

        
        /// <summary>
        /// "Add new member"-button 
        /// </summary>
        private void BtnAddNewMember_Click(object sender, EventArgs e)
        {
            if (textBoxMemberName.Text == "" || textBoxMemberPersonalID.Text == "" )
            {
                MessageBox.Show("You need to fill in all member details.", "Error!");
            }
            else if(!textBoxMemberName.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name can not contain numbers.", "Error!");
            }
            else
            {
                DateTime createdDate = DateTime.Today;
                Member member = new Member(textBoxMemberPersonalID.Text, textBoxMemberName.Text, createdDate);
                memberService.Add(member);

                MessageBox.Show("You have now added the member: " + textBoxMemberName.Text);
                textBoxMemberName.Clear();
                textBoxMemberPersonalID.Clear();
                MemberTabShowAllMembers(memberService.All());
                LoanTabShowMembers(memberService.All());
                LoanTabShowLoansByMember(memberService.All());
            }

        }
      

        //----------------------------------------------------------------------------------------------------------------------------
        // LOAN TAB
        //----------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Updates all loan listboxes
        /// </summary>
        /// <param name="currentLoans">A list of loans</param>
        /// <param name="previousLoans">A list of loans</param>
        /// <param name="overdueLoans">A list of loans</param>
        public void ShowAllLoans(IEnumerable<Loan> currentLoans, IEnumerable<Loan> previousLoans, IEnumerable<Loan> overdueLoans)
        {
            UpdateListBox(lbCurrentLoans, currentLoans);
            UpdateListBox(lbPreviousLoans, previousLoans);
            UpdateListBox(lbOverdueLoans, overdueLoans);
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
        
        /// <summary>
        /// "Add new loan"-button
        /// </summary>
        private void btnAddNewLoan_Click(object sender, EventArgs e)
        {
            if(dtLoans.Value.Date == null || (BookCopy)comboBoxBookCopies.SelectedItem == null || (Member)comboBoxMembers.SelectedItem == null)
            {
                MessageBox.Show("You need to fill in all loan details.", "Error!");
            }
            else
            {
                try
                {
                    Loan loan = new Loan(dtLoans.Value.Date, (BookCopy)comboBoxBookCopies.SelectedItem, (Member)comboBoxMembers.SelectedItem);
                    loanService.Add(loan);
                    ShowAllLoans(loanService.GetAllCurrentLoans(), loanService.GetAllPreviousLoans(), loanService.GetAllOverdueLoans());
                    TEST(loanService.All(), bookCopyService.All());
                    LoanTabShowCopies(bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("You have entered a null value.", "Error!");
                }

            }
        }

        /// <summary>
        /// "Return loan"-button
        /// </summary>
        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            if(loanService.GetAllCurrentLoans().Any())
            {
                try
                {
                    var selectedLoan = (Loan)lbCurrentLoans.SelectedItem;
                    selectedLoan.TimeOfReturn = DateTime.Today;

                    //Calculate fine
                    if ((selectedLoan.DueDate - DateTime.Today).TotalDays < 0)
                    {
                        double fine = (selectedLoan.DueDate - DateTime.Today).TotalDays * -10;
                        MessageBox.Show("Total fine for late return is: " + fine + " kr.", "This member has a late fine");
                    }

                    ShowAllLoans(loanService.GetAllCurrentLoans(), loanService.GetAllPreviousLoans(), loanService.GetAllOverdueLoans());
                    TEST(loanService.All(), bookCopyService.All());
                    LoanTabShowCopies(bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("You need to choose a current loan from the list.", "Error!");
                }
            }
            else
            {
                MessageBox.Show("There are no current loans.");
            }
        }

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

        /// <summary>
        /// Updates listbox of available books
        /// </summary>
        /// <param name="loanList">A list of loans</param>
        /// <param name="copyList">A list of copies</param>
        public void TEST(IEnumerable<Loan> loanList, IEnumerable<BookCopy> copyList)
        {
            UpdateListBox(lbAvailableBooks, bookService.GetAvailableBooks(loanList, copyList));
        }
    }
}
