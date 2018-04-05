using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.ReportSource;
using System.Text.RegularExpressions;
namespace db
{
    public partial class admin_main : Form
    {
        public admin_main()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void lOGINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void admin_main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.librarian' table. You can move, or remove it, as needed.
            //this.librarianTableAdapter.Fill(this.dataDataSet.librarian);
            // TODO: This line of code loads data into the 'dataDataSet.LOGIN' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.librarianTableAdapter.Fill(this.dataDataSet.librarian);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void librarianDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.librarianBindingSource.MoveNext();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //  this.Hide();
            //new users().Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void txtreenter_TextChanged(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == txtreenter.Text)
            {
                label4.Text = "";
            }
            else if (passwordTextBox.Text != txtreenter.Text)
            {
                label4.Text = "Password Does Not Match";
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (librarian_passwordTextBox.Text == textBox1.Text)
            {
                label8.Text = "";
            }
            else if (librarian_passwordTextBox.Text != textBox1.Text)
            {
                label8.Text = "Password Does Not Match";
            }

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ToolStripRegistartion_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void BRemove_Click(object sender, EventArgs e)
        {

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            this.librarianTableAdapter.Fill(this.dataDataSet.librarian);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            this.librarianTableAdapter.Fill(this.dataDataSet.librarian);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.librarianBindingSource.MovePrevious();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.librarianBindingSource.MoveNext();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            this.librarianBindingSource.MovePrevious();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.librarianBindingSource.MoveNext();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label8.Text = "";

            textBox1.Clear();
            librarian_addressTextBox.Clear();
            librarian_cellTextBox.Clear();
            librarian_emailTextBox.Clear();
            label6.Text = "";
            librarian_idTextBox.Clear();
            librarian_nameTextBox.Clear();
            librarian_passwordTextBox.Clear();
            librarian_surnameTextBox.Clear();
            librarian_usernameTextBox.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.librarianBindingSource.RemoveCurrent();
            this.Validate();

            this.librarianBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("Removed");
        }

        private void button19_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM librarian WHERE librarian_id='" + librarian_idTextBox.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                MessageBox.Show("Librarian ID Already Exits");

            }
            else
            {
                this.Validate();
                this.librarianBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDataSet);
                MessageBox.Show("Saved");



                Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
                if (pattern.IsMatch(librarian_cellTextBox.Text))
                {

                }
                else
                {
                    MessageBox.Show("Invalid Phone Number");
                }



                librarian_addressTextBox.Clear();
                librarian_cellTextBox.Clear();
                librarian_emailTextBox.Clear();
                textBox1.Clear();
                label6.Text = "";
                librarian_idTextBox.Clear();
                librarian_nameTextBox.Clear();
                librarian_passwordTextBox.Clear();
                librarian_surnameTextBox.Clear();
                librarian_usernameTextBox.Clear();


            }
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            this.librarianBindingSource.AddNew();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.lOGINBindingSource.AddNew();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.lOGINTableAdapter.Fill(this.dataDataSet.LOGIN);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("Saved");
            passwordTextBox.Clear();
            usernameTextBox.Clear();
            label4.Text = "";
            txtreenter.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.lOGINBindingSource.RemoveCurrent();
            this.Validate();
            this.lOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("removed");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue";
            cmd.ExecuteNonQuery();
            DataDataSet ds = new DataDataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.issue);
            CrystalReport1 myReport = new CrystalReport1();
            myReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myReport;
            con.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from books";
            cmd.ExecuteNonQuery();
            DataDataSet ds = new DataDataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.books);
            CrystalReport3 myReport = new CrystalReport3();
            myReport.SetDataSource(ds);
            crystalReportViewer2.ReportSource = myReport;
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student";
            cmd.ExecuteNonQuery();
            DataDataSet ds = new DataDataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.student);
            CrystalReport2 myReport = new CrystalReport2();
            myReport.SetDataSource(ds);
            crystalReportViewer3.ReportSource = myReport;
            con.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
            usernameTextBox.Clear();
            label4.Text = "";
            txtreenter.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.librarianTableAdapter.Fill(this.dataDataSet.librarian);
        }

        private void librarian_idTextBox_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(librarian_idTextBox.Text, out i))
            {
                {
                    MessageBox.Show("Enter Valid Librarian Id Only Numeric");
                    return;
                }
            }


        }

        private void librarian_nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(librarian_nameTextBox.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox1.Text.Remove(librarian_nameTextBox.Text.Length - 1);
                
            }
        }

        private void librarian_surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            
                 if (!System.Text.RegularExpressions.Regex.IsMatch(librarian_surnameTextBox.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox1.Text.Remove(librarian_surnameTextBox.Text.Length - 1);
                
            }
        }
    }
}

       
    

