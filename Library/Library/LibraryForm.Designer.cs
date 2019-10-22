﻿namespace Library {
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
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.checkBoxOnlyAvailable = new System.Windows.Forms.CheckBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.BtnAddNewMember = new System.Windows.Forms.Button();
            this.tabControlLibrary = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControlLibrary.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(456, 56);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(261, 342);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.Location = new System.Drawing.Point(456, 404);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(124, 34);
            this.btnShowAllBooks.TabIndex = 1;
            this.btnShowAllBooks.Text = "Show all books";
            this.btnShowAllBooks.UseVisualStyleBackColor = true;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // checkBoxOnlyAvailable
            // 
            this.checkBoxOnlyAvailable.AutoSize = true;
            this.checkBoxOnlyAvailable.Location = new System.Drawing.Point(39, 414);
            this.checkBoxOnlyAvailable.Name = "checkBoxOnlyAvailable";
            this.checkBoxOnlyAvailable.Size = new System.Drawing.Size(124, 17);
            this.checkBoxOnlyAvailable.TabIndex = 2;
            this.checkBoxOnlyAvailable.Text = "Only available books";
            this.checkBoxOnlyAvailable.UseVisualStyleBackColor = true;
            this.checkBoxOnlyAvailable.CheckedChanged += new System.EventHandler(this.checkBoxOnlyAvailable_CheckedChanged);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(128, 316);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(128, 401);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuthors.TabIndex = 4;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
            // 
            // BtnAddNewMember
            // 
            this.BtnAddNewMember.Location = new System.Drawing.Point(184, 379);
            this.BtnAddNewMember.Name = "BtnAddNewMember";
            this.BtnAddNewMember.Size = new System.Drawing.Size(124, 43);
            this.BtnAddNewMember.TabIndex = 5;
            this.BtnAddNewMember.Text = "Add new member";
            this.BtnAddNewMember.UseVisualStyleBackColor = true;
            this.BtnAddNewMember.Click += new System.EventHandler(this.BtnAddNewMember_Click);
            // 
            // tabControlLibrary
            // 
            this.tabControlLibrary.Controls.Add(this.tabPage1);
            this.tabControlLibrary.Controls.Add(this.tabPage2);
            this.tabControlLibrary.Controls.Add(this.tabPage3);
            this.tabControlLibrary.Controls.Add(this.tabPage4);
            this.tabControlLibrary.Location = new System.Drawing.Point(39, 21);
            this.tabControlLibrary.Name = "tabControlLibrary";
            this.tabControlLibrary.SelectedIndex = 0;
            this.tabControlLibrary.Size = new System.Drawing.Size(391, 498);
            this.tabControlLibrary.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxOnlyAvailable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxAuthors);
            this.tabPage2.Controls.Add(this.textBoxAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(383, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.BtnAddNewMember);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(383, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 639);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.tabControlLibrary);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.tabControlLibrary.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.CheckBox checkBoxOnlyAvailable;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Button BtnAddNewMember;
        private System.Windows.Forms.TabControl tabControlLibrary;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

