using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastingDelegatesDemo
{
  public  class Rectangle
    {
        public void GetArea(double Width,double Height)
        {
            Console.WriteLine("Area of the Rectangle" +Width * Height);
            Console.ReadLine();
        }
        public void GetPerimeter(double width,double Height)
        {
            Console.WriteLine("Perimeter of the Rectangle" +2 * (width + Height));
            Console.ReadLine();
        }
        
    }
}
