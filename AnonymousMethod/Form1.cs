using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button B = new Button();
            B.Text = "Hello World";
            B.Size = new Size(100, 50);
            B.Location = new Point(100, 100);
            this.Controls.Add(B);
            // B.Click += delegate (object sender1, EventArgs e1)     //anonymous method
            B.Click += (sender1, e1)=>

            {
                 MessageBox.Show("Good Morning");
             };
            //    B.Click += new EventHandler(b_Click);
            //}
            //private void b_Click(object sender, EventArgs e)
            //{
            //    MessageBox.Show("Good Morning");
            //}
        }
    }
}

