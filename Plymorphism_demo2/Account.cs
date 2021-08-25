using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plymorphism_demo2
{
   public class Account
    {
        public virtual void balance()
        {
            Console.WriteLine("The balance in my account is:" + 100);
        }
    }
    public class Amount:Account
    {
        public override void balance()
        {
            Console.WriteLine("The balance in my account is:" + 500);
        }
    }
}
