using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastingDelegates
{
    public delegate void RectDelegate(double width, double Height);    //defining a delegate
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of the Rectangle:" + Width * Height);
            
        }
        public void GetPerimeter(double width, double Height)
        {
            Console.WriteLine("Perimeter of the Rectangle:" + 2 * (width + Height));
           
        }
    }
}
