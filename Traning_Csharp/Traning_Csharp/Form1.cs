using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traning_Csharp
{
    public partial class Form1 : Demo
    {
        public Form1()
        {
            InitializeComponent();
            Cardetails();
        }
        public void Cardetails()
        {
            this.textBox1.Text = "yes";
            this.textBox2.Text = "yes";
            this.textBox3.Text = "yes";
        }
    }
}
