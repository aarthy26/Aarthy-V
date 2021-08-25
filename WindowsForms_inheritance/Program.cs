using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_inheritance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //public static void Main(string[] args)
        //{
        //    Car c1 = new Car();
        //    c1.Name = "BMW";
        //    c1.Color = "Red";
        //    c1.Number = "TN23456";
        //    c1.Year = 2000;
        //    Console.WriteLine(c1.Name);
        //    Console.WriteLine(c1.Color);
        //    Console.WriteLine(c1.Number);
        //    Console.WriteLine(c1.Year);
        //    Console.ReadLine();
        //}
    }
}
