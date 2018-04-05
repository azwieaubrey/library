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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new after_admin_login().Show();
            }
            else
                
            MessageBox.Show("Invalid admin username or password", "re ente password / username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Clear();
            textBox2.Clear();

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new users().Show();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.lOGINBindingSource.AddNew();
        }

        private void lOGINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.LOGIN' table. You can move, or remove it, as needed.
            
            this.Width = 415;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.lOGINTableAdapter.Fill(this.dataDataSet.LOGIN);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 777;

        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 415;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();

            new logout().Show();
        }
    }
        }
    

