using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //value type
            int a = 5;
            double b = Convert.ToDouble(a);
            decimal c = Convert.ToDecimal(a);
            bool d = true;
            //this.textBox4.Text = a.ToString();
            //this.textBox5.Text = b.ToString();
            //this.textBox6.Text = c.ToString();
            a++;
            this.textBox4.Text = a.ToString();
            d = (a < b);
            bool flag = (a > b);
            bool flag1 = (a <= b);
            this.textBox5.Text = d.ToString();
            this.textBox6.Text = flag.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = num1 + num2;
            textBox3.Text = result.ToString();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = num1 / num2;
            textBox3.Text = result.ToString();
        }      
    }
}
