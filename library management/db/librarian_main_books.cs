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



namespace db
{
    public partial class librarian_main_books : Form
    {

        public librarian_main_books()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void librarian_main_books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.issue' table. You can move, or remove it, as needed.
            this.issueTableAdapter.Fill(this.dataDataSet.issue);
            // TODO: This line of code loads data into the 'dataDataSet.bookissue' table. You can move, or remove it, as needed.
            //this.bookissueTableAdapter.Fill(this.dataDataSet.bookissue);
            // TODO: This line of code loads data into the 'dataDataSet.books' table. You can move, or remove it, as needed.
            // this.booksTableAdapter.Fill(this.dataDataSet.books);


        }

        private void button26_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
          
        }

        private void button24_Click(object sender, EventArgs e)
        {
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
          
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
           


        }

        private void button15_Click(object sender, EventArgs e)
        {
          
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void book_idTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //DESCRIPTION
            if (comboBox1.Text == "BOOK_ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT book_id, book_name, book_description, author, publisher, year FROM books WHERE book_id LIKE'" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                booksDataGridView3.DataSource = data;
            }

            if (comboBox1.Text == "BOOK_NAME")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT book_id, book_name, book_description, author, publisher, year FROM books WHERE book_name LIKE'" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                booksDataGridView3.DataSource = data;
            }
            if (comboBox1.Text == "AUTHOR")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT book_id, book_name, book_description, author, publisher, year FROM books WHERE author LIKE'" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                booksDataGridView3.DataSource = data;
            }
            if (comboBox1.Text == "DESCRIPTION")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT book_id, book_name, book_description, author, publisher, year FROM books WHERE book_description LIKE'" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                booksDataGridView3.DataSource = data;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.issueTableAdapter.FillBy(this.dataDataSet.issue);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            this.booksBindingSource.AddNew();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            book_idTextBox.Clear();
            book_nameTextBox.Clear();
            book_descriptionTextBox.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM books WHERE book_id='" + book_idTextBox.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                MessageBox.Show("Book ID Already Exits");



            }
            else
            {
                this.Validate();
                this.booksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDataSet);
                MessageBox.Show("succsefully saved");
                book_idTextBox.Clear();
                book_nameTextBox.Clear();
                book_descriptionTextBox.Clear();
                authorTextBox.Clear();
                publisherTextBox.Clear();

            }
        }
        private void button28_Click(object sender, EventArgs e)
        {
            this.booksBindingSource.MoveNext();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.booksBindingSource.MovePrevious();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.dataDataSet.books);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.booksBindingSource.MoveNext();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.dataDataSet.books);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.booksBindingSource.MovePrevious();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("succsefully updated");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.dataDataSet.books);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.booksBindingSource.MoveNext();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.booksBindingSource.MovePrevious();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.booksBindingSource.RemoveCurrent();
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("succsefully removed");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.dataDataSet.books);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.booksBindingSource.MovePrevious();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.booksBindingSource.MoveNext();
        }



        private void button8_Click_1(object sender, EventArgs e)
        {
            /*

            this.Validate();
            this.issueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("book has issued");
            librarian_IDTextBox.Clear();
            librarian_NAMETextBox.Clear();
            student_IDTextBox.Clear();
            student_NAMETextBox.Clear();
            bOOK_IDTextBox1.Clear();
            bOOK_NAMETextBox1.Clear();
             * */
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM books WHERE book_id='" + bOOK_IDTextBox2.Text + "'" + " SELECT COUNT(*) FROM librarian WHERE librarian_id='" + librarian_IDTextBox1.Text + "'" + " SELECT COUNT(*) FROM student WHERE student_no='" + student_IDTextBox1.Text + "'", con);

            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Validate();
                this.issueBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDataSet);
                MessageBox.Show("book has issued");
                librarian_IDTextBox1.Clear();
                librarian_NAMETextBox1.Clear();
                student_IDTextBox1.Clear();
                student_NAMETextBox1.Clear();
                bOOK_IDTextBox2.Clear();
                bOOK_NAMETextBox2.Clear();
            }
            else 
            {

                MessageBox.Show("Invalid Book Id or Librarian Id");
                librarian_IDTextBox.Clear();
                librarian_NAMETextBox.Clear();
                student_IDTextBox.Clear();
                student_NAMETextBox.Clear();
                bOOK_IDTextBox1.Clear();
                bOOK_NAMETextBox1.Clear();

            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            librarian_IDTextBox.Clear();
            librarian_NAMETextBox.Clear();
            student_IDTextBox.Clear();
            student_NAMETextBox.Clear();
            bOOK_IDTextBox1.Clear();
            bOOK_NAMETextBox1.Clear();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            this.issueTableAdapter.Fill(this.dataDataSet.issue);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //THIS NEED TO BE COPIED
            this.Validate();
            this.issueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("book has returned");
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.issueTableAdapter.Fill(this.dataDataSet.issue);
            
        }

        private void button15_Click_1(object sender, EventArgs e)
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

        private void button16_Click_1(object sender, EventArgs e)
        {
            this.issueBindingSource.AddNew();
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            this.issueBindingSource.AddNew();
        }

        private void bOOK_NAMETextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bOOK_IDTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void book_idTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(book_idTextBox.Text) &&
                 !int.TryParse(book_idTextBox.Text, out i)
              )
            {
                MessageBox.Show("Enter Valid Book_Id");
            }
        }

        private void librarian_IDTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(librarian_IDTextBox1.Text) &&
                 !int.TryParse(librarian_IDTextBox1.Text, out i)
              )
            {
                MessageBox.Show("Enter Valid Librarian_Id");
            }
            
        }

        private void bOOK_IDTextBox2_TextChanged(object sender, EventArgs e)
        {
            
                 int i = 0;
                 if (!string.IsNullOrEmpty(bOOK_IDTextBox2.Text) &&
                 !int.TryParse(bOOK_IDTextBox2.Text, out i)
              )
            {
                MessageBox.Show("Enter Valid Book_Id");
            }
        }

        private void student_IDTextBox1_TextChanged(object sender, EventArgs e)
        {
            

                 int i = 0;
                 if (!string.IsNullOrEmpty(student_IDTextBox1.Text) &&
                 !int.TryParse(student_IDTextBox1.Text, out i)
              )
            {
                MessageBox.Show("Enter Valid Student_Id");
            }
        }

    }
}
    

