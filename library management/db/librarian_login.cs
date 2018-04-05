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
    public partial class librarian_login : Form
    {
        public librarian_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM librarian WHERE librarian_username='" + txtUsername.Text + "' AND librarian_password='" + txtPassword.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new after_login_librarian().Show();
            }
            else
                MessageBox.Show("Invalid librarian username or password", "re ente password / username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
            txtUsername.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new users().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new users().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new users().Show();
        }
        }
    }

