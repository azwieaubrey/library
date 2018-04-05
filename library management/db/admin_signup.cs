using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace db
{
    public partial class admin_signup : Form
    {
        public admin_signup()
        {
            InitializeComponent();
        }

        private void lOGINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void admin_signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.LOGIN' table. You can move, or remove it, as needed.
            //this.lOGINTableAdapter.Fill(this.dataDataSet.LOGIN);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != passwordTextBox.Text )
            {
                label2.Text = "PASSWORD DOES NOT MATCH";
            }
            else if (usernameTextBox.Text != passwordTextBox.Text )
            {
                label2.Text = "PASSWORD MATCH";
            }
            else
                label2.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.lOGINTableAdapter.Fill(this.dataDataSet.LOGIN);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(usernameTextBox.Text) &&
                 !int.TryParse(usernameTextBox.Text, out i)
              )
            {
                MessageBox.Show("Enter Valid Age");
            }
            else
            {
                MessageBox.Show("you are "+usernameTextBox.Text+" age");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_login().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            textBox1.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.lOGINBindingSource.AddNew();
        }
        }

       
        }
    

