namespace Library
{
    partial class AddMemberForm
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
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.textBoxPersonalId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPersonalId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.Location = new System.Drawing.Point(297, 239);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(109, 44);
            this.btnAddNewMember.TabIndex = 0;
            this.btnAddNewMember.Text = "Add";
            this.btnAddNewMember.UseVisualStyleBackColor = true;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // textBoxPersonalId
            // 
            this.textBoxPersonalId.Location = new System.Drawing.Point(297, 160);
            this.textBoxPersonalId.Name = "textBoxPersonalId";
            this.textBoxPersonalId.Size = new System.Drawing.Size(109, 20);
            this.textBoxPersonalId.TabIndex = 1;
            this.textBoxPersonalId.TextChanged += new System.EventHandler(this.textBoxPersonalId_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(297, 203);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(109, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelPersonalId
            // 
            this.labelPersonalId.AutoSize = true;
            this.labelPersonalId.Location = new System.Drawing.Point(294, 144);
            this.labelPersonalId.Name = "labelPersonalId";
            this.labelPersonalId.Size = new System.Drawing.Size(60, 13);
            this.labelPersonalId.TabIndex = 3;
            this.labelPersonalId.Text = "Personal Id";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(294, 187);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPersonalId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPersonalId);
            this.Controls.Add(this.btnAddNewMember);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.TextBox textBoxPersonalId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPersonalId;
        private System.Windows.Forms.Label labelName;
    }
}