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
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adding new members
        /// </summary>
        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPersonalId.Text == "")
            {
                MessageBox.Show("", "You need to write something!");
            }
            else
            {
                // Lägg till i listan 
                // 

                MessageBox.Show("You have now added the new member: " + textBoxName.Text);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPersonalId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
