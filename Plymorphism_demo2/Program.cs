using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plymorphism_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account A1 = new Amount();
            A1.balance();
            
            Vehicle V1 = new Car("TN004",1980,"petrol");
            V1.start();
            V1.Move();
            V1.stop();
            Console.ReadLine();
        }
    }
}
