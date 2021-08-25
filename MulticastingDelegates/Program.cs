using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
           // RectDelegate obj = new RectDelegate(rect.GetArea);  //creating a instance for delegate
            RectDelegate obj = rect.GetArea;   //(another way of instantiating the delegate )
            obj += rect.GetPerimeter;        //(binding the method with delegate)
            obj.Invoke(5.2, 9.0);    //for same parameters         
            //rect.GetArea(5.2, 9.0);
            //rect.GetPerimeter(9.3, 4.2);
            Console.ReadLine();
        }
    }
}
