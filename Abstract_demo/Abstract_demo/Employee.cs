using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_demo
{
    class contractor : Employee   //derived class(inherit from base class)
    {
        public override void salary()
        {
            Console.WriteLine("annual salary:" + 200000);
        }
    }

    public abstract class Employee   //abstract class(base class)
    {      
        public abstract void salary();   //abstract method
        public void annual()     //regular method
        {
            Console.WriteLine("annual salary:" + 400000);
        }
      
    }
}
