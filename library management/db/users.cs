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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_login().Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new librarian_login().Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();

            new logout().Show();
        }

       
    }
}
