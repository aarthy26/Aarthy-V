using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Invalidageexception : Exception
    {
        public Invalidageexception(string message) : base(message)
        {

        }
    }
    public class Age
    {
        public void showAge(int Age)
        {
            if(Age==0)
            {
                throw (new Invalidageexception("zero Age Found"));
            }
            else
            {
                MessageBox.Show(string.Format("Invalidageexception:{0}", Age));
            }
        }

    }
}

