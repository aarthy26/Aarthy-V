using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_inheritance
{
    public partial class Form1 : Car
    {
        public Form1()
        {
            InitializeComponent();
            Cardetails();
            Amountdetails();
        }
        public void Cardetails()
        {
            this.Name = Name;
            this.Color = Color;
            this.Number = Number;
            this.Year = Year;
            this.textBox1.Text = this.Name;
            this.textBox2.Text = this.Color;
            this.textBox3.Text = this.Number;
            this.textBox4.Text = this.Year.ToString();
        }
        public void Amountdetails()
        {
            int iteratorWhile = 0;
            int sum = 0;
            int average = 0;

            var expenses = new List<int> { 10000, 20000, 30000, 4000};
            //for(int i=0;i<expenses.Count;i++)
            //{
            //    sum = sum + expenses[i];
            //}
            //while(iteratorWhile<expenses.Count())
            //{
            //    sum += expenses[iteratorWhile];
            //    iteratorWhile += 1;
            //}+zxzxc+
            do
            {
                sum += expenses[iteratorWhile];
                iteratorWhile += 1;
            } while (iteratorWhile < expenses.Count());
            average = sum / expenses.Count();
            this.textBox5.Text = sum.ToString();
            this.textBox6.Text = average.ToString();
        }
    }
}
