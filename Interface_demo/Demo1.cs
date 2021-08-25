using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo    //multiple inheritance
{
   interface IDemo1
    {
        void mymethod();
    }
    interface IDemo2
    {
        void mymethod2();
    }
    class Democlass:IDemo1,IDemo2
    {
        public void mymethod()
        {
            Console.WriteLine("My firstmethod");
        }
        public void mymethod2()
        {
            Console.WriteLine("My secondmethod");
        }
    }
}
