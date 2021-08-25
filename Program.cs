using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastingDelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.GetArea(2.4, 3.6);
            rect.GetPerimeter(0.3, 1.2);
            Console.ReadLine();
        }
    }
}
