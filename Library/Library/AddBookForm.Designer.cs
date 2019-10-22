namespace Library
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNrOfCopies = new System.Windows.Forms.TextBox();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(256, 99);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(121, 20);
            this.textBoxISBN.TabIndex = 0;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(256, 80);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(38, 13);
            this.labelISBN.TabIndex = 1;
            this.labelISBN.Text = "ISBN: ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(256, 132);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(256, 149);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitle.TabIndex = 3;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(256, 181);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(256, 197);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(121, 20);
            this.textBoxDescription.TabIndex = 5;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(253, 234);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Author";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(256, 250);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuthor.TabIndex = 7;
            this.comboBoxAuthor.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Copies";
            // 
            // textBoxNrOfCopies
            // 
            this.textBoxNrOfCopies.Location = new System.Drawing.Point(256, 307);
            this.textBoxNrOfCopies.Name = "textBoxNrOfCopies";
            this.textBoxNrOfCopies.Size = new System.Drawing.Size(121, 20);
            this.textBoxNrOfCopies.TabIndex = 9;
            this.textBoxNrOfCopies.TextChanged += new System.EventHandler(this.textBoxNrOfCopies_TextChanged);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(256, 357);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(121, 23);
            this.btnAddNewBook.TabIndex = 10;
            this.btnAddNewBook.Text = "Add ";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.textBoxNrOfCopies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.textBoxISBN);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNrOfCopies;
        private System.Windows.Forms.Button btnAddNewBook;
    }
}