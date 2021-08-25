using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
  interface ITransaction   //Interface
    {
        void showtransaction();     //Interface method(does not have access modifier)
        
    }
    class Transaction:ITransaction
    {
        public void showtransaction()
        {
            Console.WriteLine("The amount transfer is:" + 10000);   //the definition of interface method is provided here
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction T1 = new Transaction();
            T1.showtransaction();
            Democlass D1 = new Democlass();
            D1.mymethod();
            D1.mymethod2();
            Console.ReadLine();
        }
    }
}
