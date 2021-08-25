using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_inheritance
{
  public class Car:Form
    {
        private string name = "BMW";
        private string color = "Black";
        private string number = "TN23456";
        private int year = 2000;

        public string Name
        {
            get { return name; }
            set { value = name; }
        }
        public string Color
        {
            get { return color; }
            set { value = color; }
        }
        public string Number
        {
            get { return number; }
            set { value = number; }
        }
        public int Year
        {
            get { return year; }
            set { value = year; }
        }
    }
}
