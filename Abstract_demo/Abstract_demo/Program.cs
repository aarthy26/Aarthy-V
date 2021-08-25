using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_demo
{
   class Program
    {
        static void Main(string[] args)
        {
            contractor obj = new contractor();
            obj.salary();
            obj.annual();
            Console.ReadLine();
        }
    }
}
