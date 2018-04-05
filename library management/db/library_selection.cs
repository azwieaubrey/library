using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace db
{
    public partial class library_selection : Form
    {
        public library_selection()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new users().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new librarian_main_books().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new student_main().Show();
        }
    }
}
