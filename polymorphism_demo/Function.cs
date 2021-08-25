using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_demo
{
    //function overloading by changing the Number of parameter
    class Function
    {
        public int Add(int a,int b)
        {
           
            return a+b;
            
        }
        public int Add(int a,int b,int c)
        {
            
            return a+b+c;
        }
        //changing the datatype
        public double Add(double a,double b)
        {
            return a + b;
        }
        //changing the order of the parameter
        public void Add(string Name,int Id)
        {
            Console.WriteLine("The Name is:" + Name);
            Console.WriteLine("The Id is:" +Id);
        }
       
       
    }
}
