using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_demo
{
  
    class Program
    {
        enum DayOfWeek
        {
            Monday,      //0
            Tuesday,     //1
            Wednesday,    //2
            Thursday,     //3
            Friday        //4
        }
        static void Main(string[] args)
        {
            //DayOfWeek Myvar = new DayOfWeek.Monday;
            int Myvar = (int)DayOfWeek.Monday;
            Console.WriteLine(Myvar);          
            Console.ReadLine();
        }
    }
}
