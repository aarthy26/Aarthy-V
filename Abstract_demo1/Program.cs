using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Absderived A1 = new Absderived();
            A1.Number = 789;
            Console.WriteLine(A1.Number);
            Console.ReadLine();
        }
    }
}
