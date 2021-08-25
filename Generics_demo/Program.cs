using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Datastore<string,string> store = new Datastore<string,string>();
            store.value = "KY07";
            store.Data = "Welcome";
            Console.WriteLine(store.value);
            Console.WriteLine(store.Data);
            Demo<int> obj1 = new Demo<int>();  //instantiate generic with integer
            obj1.Add(1);
            obj1.Add(2);
            obj1.Add(3);
            obj1.Add(4);
            obj1.Add(5);
            obj1.Add(6);

            //displaying values
            for (int i=0;i<6;i++)
            {
                Console.WriteLine(obj1[i]);
            }
            Console.ReadLine();
        }
    }
}
