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

            // Subscribers
            bookService.Updated += books_Updated; 
            authorService.Updated += authors_Updated;
            memberService.Updated += members_Updated;
            bookCopyService.Updated += copies_Updated;
            loanService.Updated += loans_Updated;

            // Content
            UpdateListBox(lbBooks, bookService.All());
            UpdateComboBox(comboBoxBook, bookService.All());

            UpdateListBox(lbAuthors, authorService.All());
            UpdateComboBox(comboBoxAuthor, authorService.All());
            UpdateComboBox(comboBoxBooksByAuthor, authorService.All());

            UpdateListBox(lbMembers, memberService.All());
            UpdateComboBox(comboBoxLoansByMember, memberService.All());
            UpdateComboBox(comboBoxMembers, memberService.All());

            UpdateListBox(lbAvailableBooks, bookService.GetAvailableBooks(loanService.All(), bookCopyService.All()));
            UpdateComboBox(comboBoxBookCopies, bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));

            UpdateListBox(lbCurrentLoans, loanService.GetAllCurrentLoans());
            UpdateListBox(lbPreviousLoans, loanService.GetAllPreviousLoans());
            UpdateListBox(lbOverdueLoans, loanService.GetAllOverdueLoans());
        }

        ///
        /// METHODS TO UPDATE CONTENT
        /// 

        private void books_Updated(object sender, EventArgs e)
        {
            UpdateListBox(lbBooks, bookService.All());
            UpdateComboBox(comboBoxBook, bookService.All());
        }

        private void authors_Updated(object sender, EventArgs e)
        {
            UpdateListBox(lbAuthors, authorService.All());
            UpdateComboBox(comboBoxAuthor, authorService.All());
            UpdateComboBox(comboBoxBooksByAuthor, authorService.All());
        }

        private void members_Updated(object sender, EventArgs e)
        {
            UpdateListBox(lbMembers, memberService.All());
            UpdateComboBox(comboBoxLoansByMember, memberService.All());
            UpdateComboBox(comboBoxMembers, memberService.All());
        }

        private void copies_Updated(object sender, EventArgs e)
        {

            UpdateListBox(lbBooks, bookService.All());
            UpdateListBox(lbAvailableBooks, bookService.GetAvailableBooks(loanService.All(), bookCopyService.All()));
            UpdateComboBox(comboBoxBookCopies, bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));
        }

        private void loans_Updated(object sender, EventArgs e)
        {
            UpdateListBox(lbCurrentLoans, loanService.GetAllCurrentLoans());
            UpdateListBox(lbPreviousLoans, loanService.GetAllPreviousLoans());
            UpdateListBox(lbOverdueLoans, loanService.GetAllOverdueLoans());
            UpdateListBox(lbAvailableBooks, bookService.GetAvailableBooks(loanService.All(), bookCopyService.All()));
            UpdateComboBox(comboBoxBookCopies, bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));
        }


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
            }
        }

        /// <summary>
        /// "Show all books"-button
        /// </summary>
        private void btnShowAllBooks_Click_1(object sender, EventArgs e)
        {
            UpdateListBox(lbBooks, bookService.All());
        }



        ///-----------------
        /// ADD NEW COPIES
        /// ----------------

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
                    UpdateListBox(lbBooks, bookService.All());
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
        /// "Add new author"-knapp
        /// </summary>
         private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {

            if (textBoxAuthorName.Text == "")
            {
                MessageBox.Show("You need to enter a name of the author.", "Error!");
            }
            else if (textBoxMemberName.Text.Any(char.IsNumber) || textBoxMemberName.Text.Any(char.IsSymbol) || textBoxMemberName.Text.Any(char.IsPunctuation))
            {
                MessageBox.Show("Name can only contain alphabetical letters.", "Error!");
            }
            else
            {
                Author author = new Author(textBoxAuthorName.Text);
                authorService.Add(author);

                MessageBox.Show("You have now added the author: " + textBoxAuthorName.Text);
                textBoxAuthorName.Clear();
            }
        }

                                                   
        //----------------------------------------------------------------------------------------------------------------------------
        // MEMBERS TAB
        //----------------------------------------------------------------------------------------------------------------------------
 
        /// <summary>
        /// "Add new member"-button 
        /// </summary>
        private void BtnAddNewMember_Click(object sender, EventArgs e)
        {
            if (textBoxMemberName.Text == "" || textBoxMemberPersonalID.Text == "" )
            {
                MessageBox.Show("You need to fill in all member details.", "Error!");
            }
            else if(textBoxMemberName.Text.Any(char.IsNumber) || textBoxMemberName.Text.Any(char.IsSymbol) || textBoxMemberName.Text.Any(char.IsPunctuation))
            {
                MessageBox.Show("Name can only contain alphabetical letters.", "Error!");
            }
            else
            {
                DateTime createdDate = DateTime.Today;
                Member member = new Member(textBoxMemberPersonalID.Text, textBoxMemberName.Text, createdDate);
                memberService.Add(member);

                MessageBox.Show("You have now added the member: " + textBoxMemberName.Text);
                textBoxMemberName.Clear();
                textBoxMemberPersonalID.Clear();
            }
        }
      

        //----------------------------------------------------------------------------------------------------------------------------
        // LOAN TAB
        //----------------------------------------------------------------------------------------------------------------------------

      
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

                    comboBoxBookCopies.SelectedIndex = -1;
                    comboBoxMembers.SelectedItem = null;
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

                    UpdateListBox(lbCurrentLoans, loanService.GetAllCurrentLoans());
                    UpdateListBox(lbPreviousLoans, loanService.GetAllPreviousLoans());
                    UpdateListBox(lbOverdueLoans, loanService.GetAllOverdueLoans());
                    UpdateListBox(lbAvailableBooks, bookService.GetAvailableBooks(loanService.All(), bookCopyService.All()));
                    UpdateComboBox(comboBoxBookCopies, bookCopyService.GetAvailableBookCopies(loanService.All(), bookCopyService.All()));
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
        /// Button to filter loans by entering a member
        /// </summary>
        private void btnShowLoansByMember_Click(object sender, EventArgs e)
        {
            UpdateListBox(lbOverdueLoans, loanService.GetAllOverdueLoansByMember((Member)comboBoxLoansByMember.SelectedItem));
            UpdateListBox(lbCurrentLoans, loanService.GetAllCurrentLoansByMember((Member)comboBoxLoansByMember.SelectedItem));
            UpdateListBox(lbPreviousLoans, loanService.GetAllPreviousLoansByMember((Member)comboBoxLoansByMember.SelectedItem));
        }

        private void btnShowAllLoans_Click(object sender, EventArgs e)
        {
            UpdateListBox(lbCurrentLoans, loanService.GetAllCurrentLoans());
            UpdateListBox(lbPreviousLoans, loanService.GetAllPreviousLoans());
            UpdateListBox(lbOverdueLoans, loanService.GetAllOverdueLoans());
        }
    }
}
