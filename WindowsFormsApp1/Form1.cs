using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X = int.Parse(textBox1.Text);
            int Y = int.Parse(textBox2.Text);
            int result = 0;

            try
            {
                result = X / Y;
            }
            //catch(IndexOutOfRangeException err)
            catch(Exception err)
            {
                MessageBox.Show(string.Format("Exception caught: {0}", err));
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            try
            {
                string i = dt.Tables[0].Rows[0][0].ToString();
            }
            catch(IndexOutOfRangeException err)
            {
                MessageBox.Show(string.Format("Exception caught:{0}", err));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            try
            {
                int i = dt.Rows.Count;
            }
            catch(Exception err)
            {
                MessageBox.Show(string.Format("Execption caught: {0}", err));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(textBox1.Text);
            int Y = Convert.ToInt32(textBox2.Text);
            int result = 0;

            try
            {
                result = X / Y;
            }
            //catch(IndexOutOfRangeException err)
            catch (FormatException err)
            {
                MessageBox.Show(string.Format("Exception caught: {0}", err));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Age A1 = new Age();
            try
            {
                A1.showAge(Convert.ToInt32(textBox1.Text));
            }
            catch(Exception err)
            {
                MessageBox.Show(string.Format("Invalidageexception:{0}", err));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                File.Open("c:\\notes.txt", FileMode.Open);
            }
            catch(FileNotFoundException err)
            {
                MessageBox.Show(string.Format("FileNotFoundException:{0}", err));
;            }
        }
    }
}
