using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginwindow_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = textBox1.Text;
            password = textBox2.Text;
            if (username=="admin" && password=="admin")
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }
    }
}
