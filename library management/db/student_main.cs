using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace db
{
    public partial class student_main : Form
    {
        public student_main()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void student_main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.dataDataSet.books);
            // TODO: This line of code loads data into the 'dataDataSet.student' table. You can move, or remove it, as needed.


        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("succesfully saved");
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "STUDENT_NO")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT student_no, student_name, student_surname, student_address, student_cell FROM student WHERE student_no LIKE'" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                studentBindingSource.DataSource = data;
            }

            if (comboBox1.Text == "STUDENT_NAME")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT student_no, student_name, student_surname, student_address, student_cell FROM student WHERE student_name LIKE'" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                studentBindingSource.DataSource = data;
            }
            //ADDRESS
            if (comboBox1.Text == "ADDRESS")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT student_no, student_name, student_surname, student_address, student_cell FROM student WHERE student_address LIKE'" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                studentBindingSource.DataSource = data;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            new library_selection().Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.studentBindingSource.AddNew();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dataDataSet.student);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ENGE_RIANDE\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM student WHERE student_no='" + student_noTextBox.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                MessageBox.Show("Student No Already Exits");

            }
            else
            {
                this.Validate();
                this.studentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDataSet);
                MessageBox.Show("succesfully saved");
                student_addressTextBox.Clear();
                student_nameTextBox.Clear();
                student_noTextBox.Clear();
                student_surnameTextBox.Clear();
                student_cellTextBox.Clear();
                Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
                if (pattern.IsMatch(student_cellTextBox.Text))
                {

                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                }


            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            student_addressTextBox.Clear();
            student_nameTextBox.Clear();
            student_noTextBox.Clear();
            student_surnameTextBox.Clear();
            student_cellTextBox.Clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.studentBindingSource.MoveNext();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dataDataSet.student);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.studentBindingSource.MovePrevious();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dataDataSet.student);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MoveNext();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.MovePrevious();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("succesfully udpdated");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.RemoveCurrent();
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);
            MessageBox.Show("succesfully removed");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dataDataSet.student);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.studentBindingSource.MovePrevious();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.studentBindingSource.MoveNext();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void student_noTextBox_TextChanged(object sender, EventArgs e)
        {

            int i;
            if (!int.TryParse(student_noTextBox.Text, out i))
            {
                {
                    MessageBox.Show("Enter Valid Student No");
                    return;
                }
            }
        }

        private void student_nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(student_nameTextBox.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox1.Text.Remove(student_nameTextBox.Text.Length - 1);

            }
        }

        private void student_surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(student_surnameTextBox.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox1.Text.Remove(student_surnameTextBox.Text.Length - 1);

                
            }
        }
    }
}