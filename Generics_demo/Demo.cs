using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_demo
{
    class Demo<T>
    {
        // define an array of generic type with length 6
        T[] obj = new T[6];
        int count = 0;

        // adding items into generics type
        public void Add(T items)
        {
            //checking length
            if(count +1<7)
            {
                obj[count] = items;
            }
            count++;
        }
        //idexer for foreach statement iteration
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
}
