using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public delegate string delegateGreeting(string Name);
    class Program
    {
        //public static string Greeting(string Name)
        //{
        //    return "Hello"  +  Name   +  "Good morning";
        //}

        static void Main(string[] args)
        {
            // delegateGreeting obj = new delegateGreeting(Greeting);
            delegateGreeting obj =  (Name)=>    ///LambdaExpression
            {
                return "Hello" + Name + "Good morning";
            };
            string str = obj.Invoke("Everyone");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
