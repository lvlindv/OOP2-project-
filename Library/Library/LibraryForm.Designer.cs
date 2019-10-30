namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.BtnAddNewMember = new System.Windows.Forms.Button();
            this.tabControlLibrary = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxBooksByAuthor = new System.Windows.Forms.ComboBox();
            this.btnBooksByAuthor = new System.Windows.Forms.Button();
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.lbAvailableBooks = new System.Windows.Forms.ListBox();
            this.labelAvailableBooks = new System.Windows.Forms.Label();
            this.labelAllBooks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.numericUpDownCopies = new System.Windows.Forms.NumericUpDown();
            this.labelBook = new System.Windows.Forms.Label();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.btnAddNewCopy = new System.Windows.Forms.Button();
            this.groupBoxBookInfo = new System.Windows.Forms.GroupBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.btnAddNewAuthor = new System.Windows.Forms.Button();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.groupBoxAddNewMember = new System.Windows.Forms.GroupBox();
            this.textBoxMemberPersonalID = new System.Windows.Forms.TextBox();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPersonalID = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowLoansByMember = new System.Windows.Forms.Button();
            this.comboBoxLoansByMember = new System.Windows.Forms.ComboBox();
            this.labelReturned = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelOverdue = new System.Windows.Forms.Label();
            this.btnReturnLoan = new System.Windows.Forms.Button();
            this.lbOverdueLoans = new System.Windows.Forms.ListBox();
            this.lbPreviousLoans = new System.Windows.Forms.ListBox();
            this.lbCurrentLoans = new System.Windows.Forms.ListBox();
            this.groupBoxAddNewLoan = new System.Windows.Forms.GroupBox();
            this.dtLoans = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMembers = new System.Windows.Forms.ComboBox();
            this.comboBoxBookCopies = new System.Windows.Forms.ComboBox();
            this.btnAddNewLoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelNameOfAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlLibrary.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).BeginInit();
            this.groupBoxBookInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxAddNewMember.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAddNewLoan.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 15;
            this.lbBooks.Location = new System.Drawing.Point(39, 237);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(524, 109);
            this.lbBooks.TabIndex = 0;
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(23, 66);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(124, 21);
            this.textBoxAuthorName.TabIndex = 3;
            // 
            // BtnAddNewMember
            // 
            this.BtnAddNewMember.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewMember.Location = new System.Drawing.Point(20, 178);
            this.BtnAddNewMember.Name = "BtnAddNewMember";
            this.BtnAddNewMember.Size = new System.Drawing.Size(100, 41);
            this.BtnAddNewMember.TabIndex = 5;
            this.BtnAddNewMember.Text = "Add";
            this.BtnAddNewMember.UseVisualStyleBackColor = true;
            this.BtnAddNewMember.Click += new System.EventHandler(this.BtnAddNewMember_Click);
            // 
            // tabControlLibrary
            // 
            this.tabControlLibrary.Controls.Add(this.tabPage1);
            this.tabControlLibrary.Controls.Add(this.tabPage2);
            this.tabControlLibrary.Controls.Add(this.tabPage3);
            this.tabControlLibrary.Controls.Add(this.tabPage4);
            this.tabControlLibrary.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlLibrary.Location = new System.Drawing.Point(68, 81);
            this.tabControlLibrary.Name = "tabControlLibrary";
            this.tabControlLibrary.SelectedIndex = 0;
            this.tabControlLibrary.Size = new System.Drawing.Size(1043, 548);
            this.tabControlLibrary.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnShowAllBooks);
            this.tabPage1.Controls.Add(this.lbAvailableBooks);
            this.tabPage1.Controls.Add(this.labelAvailableBooks);
            this.tabPage1.Controls.Add(this.labelAllBooks);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBoxBookInfo);
            this.tabPage1.Controls.Add(this.lbBooks);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxBooksByAuthor);
            this.groupBox3.Controls.Add(this.btnBooksByAuthor);
            this.groupBox3.Location = new System.Drawing.Point(178, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 131);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show books by athor";
            // 
            // comboBoxBooksByAuthor
            // 
            this.comboBoxBooksByAuthor.FormattingEnabled = true;
            this.comboBoxBooksByAuthor.Location = new System.Drawing.Point(32, 45);
            this.comboBoxBooksByAuthor.Name = "comboBoxBooksByAuthor";
            this.comboBoxBooksByAuthor.Size = new System.Drawing.Size(149, 23);
            this.comboBoxBooksByAuthor.TabIndex = 17;
            // 
            // btnBooksByAuthor
            // 
            this.btnBooksByAuthor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksByAuthor.Location = new System.Drawing.Point(32, 72);
            this.btnBooksByAuthor.Name = "btnBooksByAuthor";
            this.btnBooksByAuthor.Size = new System.Drawing.Size(149, 38);
            this.btnBooksByAuthor.TabIndex = 18;
            this.btnBooksByAuthor.Text = "Show";
            this.btnBooksByAuthor.UseVisualStyleBackColor = true;
            this.btnBooksByAuthor.Click += new System.EventHandler(this.btnBooksByAuthor_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllBooks.Location = new System.Drawing.Point(39, 364);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(121, 131);
            this.btnShowAllBooks.TabIndex = 22;
            this.btnShowAllBooks.Text = "Show all books";
            this.btnShowAllBooks.UseVisualStyleBackColor = true;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click_1);
            // 
            // lbAvailableBooks
            // 
            this.lbAvailableBooks.FormattingEnabled = true;
            this.lbAvailableBooks.ItemHeight = 15;
            this.lbAvailableBooks.Location = new System.Drawing.Point(39, 47);
            this.lbAvailableBooks.Name = "lbAvailableBooks";
            this.lbAvailableBooks.Size = new System.Drawing.Size(524, 109);
            this.lbAvailableBooks.TabIndex = 21;
            // 
            // labelAvailableBooks
            // 
            this.labelAvailableBooks.AutoSize = true;
            this.labelAvailableBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableBooks.Location = new System.Drawing.Point(35, 24);
            this.labelAvailableBooks.Name = "labelAvailableBooks";
            this.labelAvailableBooks.Size = new System.Drawing.Size(136, 20);
            this.labelAvailableBooks.TabIndex = 20;
            this.labelAvailableBooks.Text = "Available Books";
            // 
            // labelAllBooks
            // 
            this.labelAllBooks.AutoSize = true;
            this.labelAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllBooks.Location = new System.Drawing.Point(35, 214);
            this.labelAllBooks.Name = "labelAllBooks";
            this.labelAllBooks.Size = new System.Drawing.Size(84, 20);
            this.labelAllBooks.TabIndex = 19;
            this.labelAllBooks.Text = "All Books";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCondition);
            this.groupBox1.Controls.Add(this.numericUpDownCopies);
            this.groupBox1.Controls.Add(this.labelBook);
            this.groupBox1.Controls.Add(this.comboBoxBook);
            this.groupBox1.Controls.Add(this.btnAddNewCopy);
            this.groupBox1.Location = new System.Drawing.Point(776, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 318);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add book copy";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(13, 185);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(96, 15);
            this.labelCondition.TabIndex = 17;
            this.labelCondition.Text = "Condition of copy";
            // 
            // numericUpDownCopies
            // 
            this.numericUpDownCopies.Location = new System.Drawing.Point(16, 201);
            this.numericUpDownCopies.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCopies.Name = "numericUpDownCopies";
            this.numericUpDownCopies.Size = new System.Drawing.Size(170, 21);
            this.numericUpDownCopies.TabIndex = 16;
            this.numericUpDownCopies.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(13, 125);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(33, 15);
            this.labelBook.TabIndex = 15;
            this.labelBook.Text = "Book";
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(16, 141);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(170, 23);
            this.comboBoxBook.TabIndex = 14;
            // 
            // btnAddNewCopy
            // 
            this.btnAddNewCopy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCopy.Location = new System.Drawing.Point(16, 241);
            this.btnAddNewCopy.Name = "btnAddNewCopy";
            this.btnAddNewCopy.Size = new System.Drawing.Size(170, 43);
            this.btnAddNewCopy.TabIndex = 7;
            this.btnAddNewCopy.Text = "Add";
            this.btnAddNewCopy.UseVisualStyleBackColor = true;
            this.btnAddNewCopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxBookInfo
            // 
            this.groupBoxBookInfo.Controls.Add(this.labelAuthor);
            this.groupBoxBookInfo.Controls.Add(this.comboBoxAuthor);
            this.groupBoxBookInfo.Controls.Add(this.textBoxDescription);
            this.groupBoxBookInfo.Controls.Add(this.labelDescription);
            this.groupBoxBookInfo.Controls.Add(this.textBoxTitle);
            this.groupBoxBookInfo.Controls.Add(this.labelTitle);
            this.groupBoxBookInfo.Controls.Add(this.labelISBN);
            this.groupBoxBookInfo.Controls.Add(this.textBoxISBN);
            this.groupBoxBookInfo.Controls.Add(this.btnAddNewBook);
            this.groupBoxBookInfo.Location = new System.Drawing.Point(583, 40);
            this.groupBoxBookInfo.Name = "groupBoxBookInfo";
            this.groupBoxBookInfo.Size = new System.Drawing.Size(173, 318);
            this.groupBoxBookInfo.TabIndex = 16;
            this.groupBoxBookInfo.TabStop = false;
            this.groupBoxBookInfo.Text = "Add new book";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(13, 181);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(42, 15);
            this.labelAuthor.TabIndex = 15;
            this.labelAuthor.Text = "Author";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(16, 201);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(124, 23);
            this.comboBoxAuthor.TabIndex = 14;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(16, 141);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(200, 200);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(124, 21);
            this.textBoxDescription.TabIndex = 13;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(13, 125);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(64, 15);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(16, 93);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(124, 21);
            this.textBoxTitle.TabIndex = 11;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(13, 77);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 15);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Title";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(13, 34);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(34, 15);
            this.labelISBN.TabIndex = 9;
            this.labelISBN.Text = "ISBN";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(16, 50);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(124, 21);
            this.textBoxISBN.TabIndex = 8;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.Location = new System.Drawing.Point(16, 241);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(124, 43);
            this.btnAddNewBook.TabIndex = 7;
            this.btnAddNewBook.Text = "Add";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.labelAuthorName);
            this.tabPage2.Controls.Add(this.lbAuthors);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(328, 114);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(35, 15);
            this.labelAuthorName.TabIndex = 9;
            this.labelAuthorName.Text = "Name";
            // 
            // btnAddNewAuthor
            // 
            this.btnAddNewAuthor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAuthor.Location = new System.Drawing.Point(23, 92);
            this.btnAddNewAuthor.Name = "btnAddNewAuthor";
            this.btnAddNewAuthor.Size = new System.Drawing.Size(124, 43);
            this.btnAddNewAuthor.TabIndex = 8;
            this.btnAddNewAuthor.Text = "Add";
            this.btnAddNewAuthor.UseVisualStyleBackColor = true;
            this.btnAddNewAuthor.Click += new System.EventHandler(this.btnAddNewAuthor_Click);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.ItemHeight = 15;
            this.lbAuthors.Location = new System.Drawing.Point(41, 47);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(261, 334);
            this.lbAuthors.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lbMembers);
            this.tabPage3.Controls.Add(this.groupBoxAddNewMember);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1035, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Members";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 15;
            this.lbMembers.Location = new System.Drawing.Point(39, 46);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(258, 304);
            this.lbMembers.TabIndex = 6;
            // 
            // groupBoxAddNewMember
            // 
            this.groupBoxAddNewMember.Controls.Add(this.textBoxMemberPersonalID);
            this.groupBoxAddNewMember.Controls.Add(this.BtnAddNewMember);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxMemberName);
            this.groupBoxAddNewMember.Controls.Add(this.labelName);
            this.groupBoxAddNewMember.Controls.Add(this.labelPersonalID);
            this.groupBoxAddNewMember.Location = new System.Drawing.Point(316, 46);
            this.groupBoxAddNewMember.Name = "groupBoxAddNewMember";
            this.groupBoxAddNewMember.Size = new System.Drawing.Size(153, 248);
            this.groupBoxAddNewMember.TabIndex = 13;
            this.groupBoxAddNewMember.TabStop = false;
            this.groupBoxAddNewMember.Text = "Add new member";
            // 
            // textBoxMemberPersonalID
            // 
            this.textBoxMemberPersonalID.Location = new System.Drawing.Point(20, 60);
            this.textBoxMemberPersonalID.Name = "textBoxMemberPersonalID";
            this.textBoxMemberPersonalID.Size = new System.Drawing.Size(100, 21);
            this.textBoxMemberPersonalID.TabIndex = 12;
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(20, 114);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(100, 21);
            this.textBoxMemberName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 15);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelPersonalID
            // 
            this.labelPersonalID.AutoSize = true;
            this.labelPersonalID.Location = new System.Drawing.Point(20, 43);
            this.labelPersonalID.Name = "labelPersonalID";
            this.labelPersonalID.Size = new System.Drawing.Size(64, 15);
            this.labelPersonalID.TabIndex = 8;
            this.labelPersonalID.Text = "Personal ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.labelReturned);
            this.tabPage4.Controls.Add(this.labelCurrent);
            this.tabPage4.Controls.Add(this.labelOverdue);
            this.tabPage4.Controls.Add(this.btnReturnLoan);
            this.tabPage4.Controls.Add(this.lbOverdueLoans);
            this.tabPage4.Controls.Add(this.lbPreviousLoans);
            this.tabPage4.Controls.Add(this.lbCurrentLoans);
            this.tabPage4.Controls.Add(this.groupBoxAddNewLoan);
            this.tabPage4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1035, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Loans";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowLoansByMember);
            this.groupBox2.Controls.Add(this.comboBoxLoansByMember);
            this.groupBox2.Location = new System.Drawing.Point(316, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 145);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show loans by specific member";
            // 
            // btnShowLoansByMember
            // 
            this.btnShowLoansByMember.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLoansByMember.Location = new System.Drawing.Point(6, 96);
            this.btnShowLoansByMember.Name = "btnShowLoansByMember";
            this.btnShowLoansByMember.Size = new System.Drawing.Size(206, 23);
            this.btnShowLoansByMember.TabIndex = 7;
            this.btnShowLoansByMember.Text = "Show";
            this.btnShowLoansByMember.UseVisualStyleBackColor = true;
            this.btnShowLoansByMember.Click += new System.EventHandler(this.btnShowLoansByMember_Click);
            // 
            // comboBoxLoansByMember
            // 
            this.comboBoxLoansByMember.FormattingEnabled = true;
            this.comboBoxLoansByMember.Location = new System.Drawing.Point(6, 69);
            this.comboBoxLoansByMember.Name = "comboBoxLoansByMember";
            this.comboBoxLoansByMember.Size = new System.Drawing.Size(206, 23);
            this.comboBoxLoansByMember.TabIndex = 7;
            // 
            // labelReturned
            // 
            this.labelReturned.AutoSize = true;
            this.labelReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturned.Location = new System.Drawing.Point(63, 229);
            this.labelReturned.Name = "labelReturned";
            this.labelReturned.Size = new System.Drawing.Size(59, 13);
            this.labelReturned.TabIndex = 10;
            this.labelReturned.Text = "Returned";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.Location = new System.Drawing.Point(63, 121);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(48, 13);
            this.labelCurrent.TabIndex = 9;
            this.labelCurrent.Text = "Current";
            // 
            // labelOverdue
            // 
            this.labelOverdue.AutoSize = true;
            this.labelOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverdue.Location = new System.Drawing.Point(63, 18);
            this.labelOverdue.Name = "labelOverdue";
            this.labelOverdue.Size = new System.Drawing.Size(59, 13);
            this.labelOverdue.TabIndex = 8;
            this.labelOverdue.Text = "Overdue ";
            // 
            // btnReturnLoan
            // 
            this.btnReturnLoan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnLoan.Location = new System.Drawing.Point(553, 333);
            this.btnReturnLoan.Name = "btnReturnLoan";
            this.btnReturnLoan.Size = new System.Drawing.Size(183, 145);
            this.btnReturnLoan.TabIndex = 7;
            this.btnReturnLoan.Text = "Return selected loan";
            this.btnReturnLoan.UseVisualStyleBackColor = true;
            this.btnReturnLoan.Click += new System.EventHandler(this.btnReturnLoan_Click);
            // 
            // lbOverdueLoans
            // 
            this.lbOverdueLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverdueLoans.ForeColor = System.Drawing.Color.Red;
            this.lbOverdueLoans.FormattingEnabled = true;
            this.lbOverdueLoans.Location = new System.Drawing.Point(66, 34);
            this.lbOverdueLoans.Name = "lbOverdueLoans";
            this.lbOverdueLoans.Size = new System.Drawing.Size(670, 82);
            this.lbOverdueLoans.TabIndex = 3;
            // 
            // lbPreviousLoans
            // 
            this.lbPreviousLoans.FormattingEnabled = true;
            this.lbPreviousLoans.ItemHeight = 15;
            this.lbPreviousLoans.Location = new System.Drawing.Point(66, 245);
            this.lbPreviousLoans.Name = "lbPreviousLoans";
            this.lbPreviousLoans.Size = new System.Drawing.Size(670, 79);
            this.lbPreviousLoans.TabIndex = 2;
            // 
            // lbCurrentLoans
            // 
            this.lbCurrentLoans.FormattingEnabled = true;
            this.lbCurrentLoans.ItemHeight = 15;
            this.lbCurrentLoans.Location = new System.Drawing.Point(66, 137);
            this.lbCurrentLoans.Name = "lbCurrentLoans";
            this.lbCurrentLoans.Size = new System.Drawing.Size(670, 79);
            this.lbCurrentLoans.TabIndex = 1;
            // 
            // groupBoxAddNewLoan
            // 
            this.groupBoxAddNewLoan.Controls.Add(this.dtLoans);
            this.groupBoxAddNewLoan.Controls.Add(this.comboBoxMembers);
            this.groupBoxAddNewLoan.Controls.Add(this.comboBoxBookCopies);
            this.groupBoxAddNewLoan.Controls.Add(this.btnAddNewLoan);
            this.groupBoxAddNewLoan.Location = new System.Drawing.Point(66, 333);
            this.groupBoxAddNewLoan.Name = "groupBoxAddNewLoan";
            this.groupBoxAddNewLoan.Size = new System.Drawing.Size(229, 145);
            this.groupBoxAddNewLoan.TabIndex = 11;
            this.groupBoxAddNewLoan.TabStop = false;
            this.groupBoxAddNewLoan.Text = "Add new loan";
            // 
            // dtLoans
            // 
            this.dtLoans.Location = new System.Drawing.Point(6, 28);
            this.dtLoans.Name = "dtLoans";
            this.dtLoans.Size = new System.Drawing.Size(206, 21);
            this.dtLoans.TabIndex = 4;
            // 
            // comboBoxMembers
            // 
            this.comboBoxMembers.FormattingEnabled = true;
            this.comboBoxMembers.Location = new System.Drawing.Point(6, 81);
            this.comboBoxMembers.Name = "comboBoxMembers";
            this.comboBoxMembers.Size = new System.Drawing.Size(206, 23);
            this.comboBoxMembers.TabIndex = 5;
            // 
            // comboBoxBookCopies
            // 
            this.comboBoxBookCopies.FormattingEnabled = true;
            this.comboBoxBookCopies.Location = new System.Drawing.Point(6, 54);
            this.comboBoxBookCopies.Name = "comboBoxBookCopies";
            this.comboBoxBookCopies.Size = new System.Drawing.Size(206, 23);
            this.comboBoxBookCopies.TabIndex = 6;
            // 
            // btnAddNewLoan
            // 
            this.btnAddNewLoan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLoan.Location = new System.Drawing.Point(6, 108);
            this.btnAddNewLoan.Name = "btnAddNewLoan";
            this.btnAddNewLoan.Size = new System.Drawing.Size(206, 23);
            this.btnAddNewLoan.TabIndex = 0;
            this.btnAddNewLoan.Text = "Add";
            this.btnAddNewLoan.UseVisualStyleBackColor = true;
            this.btnAddNewLoan.Click += new System.EventHandler(this.btnAddNewLoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Author";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.labelNameOfAuthor);
            this.groupBox4.Controls.Add(this.textBoxAuthorName);
            this.groupBox4.Controls.Add(this.btnAddNewAuthor);
            this.groupBox4.Location = new System.Drawing.Point(308, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 158);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add new author";
            // 
            // labelNameOfAuthor
            // 
            this.labelNameOfAuthor.AutoSize = true;
            this.labelNameOfAuthor.Location = new System.Drawing.Point(20, 50);
            this.labelNameOfAuthor.Name = "labelNameOfAuthor";
            this.labelNameOfAuthor.Size = new System.Drawing.Size(35, 15);
            this.labelNameOfAuthor.TabIndex = 9;
            this.labelNameOfAuthor.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "All Authors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "All Members";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(72, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Welcome to the Library!";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 667);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControlLibrary);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.tabControlLibrary.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).EndInit();
            this.groupBoxBookInfo.ResumeLayout(false);
            this.groupBoxBookInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxAddNewMember.ResumeLayout(false);
            this.groupBoxAddNewMember.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxAddNewLoan.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Button BtnAddNewMember;
        private System.Windows.Forms.TabControl tabControlLibrary;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Button btnAddNewAuthor;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPersonalID;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.TextBox textBoxMemberPersonalID;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Button btnBooksByAuthor;
        private System.Windows.Forms.ComboBox comboBoxBooksByAuthor;
        private System.Windows.Forms.GroupBox groupBoxBookInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownCopies;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Button btnAddNewCopy;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.ListBox lbOverdueLoans;
        private System.Windows.Forms.ListBox lbPreviousLoans;
        private System.Windows.Forms.ListBox lbCurrentLoans;
        private System.Windows.Forms.Button btnReturnLoan;
        private System.Windows.Forms.ComboBox comboBoxBookCopies;
        private System.Windows.Forms.ComboBox comboBoxMembers;
        private System.Windows.Forms.DateTimePicker dtLoans;
        private System.Windows.Forms.Label labelReturned;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelOverdue;
        private System.Windows.Forms.GroupBox groupBoxAddNewLoan;
        private System.Windows.Forms.GroupBox groupBoxAddNewMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowLoansByMember;
        private System.Windows.Forms.ComboBox comboBoxLoansByMember;
        private System.Windows.Forms.Button btnAddNewLoan;
        private System.Windows.Forms.Label labelAvailableBooks;
        private System.Windows.Forms.Label labelAllBooks;
        private System.Windows.Forms.ListBox lbAvailableBooks;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelNameOfAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

