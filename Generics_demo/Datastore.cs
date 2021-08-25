using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_demo
{
    //class Datastore<T>
    //{
    //    public T Data { get; set; }

    //}
    class Datastore<Tkey,Tstore>
    {
        public Tkey value { get; set; }
        public Tstore Data { get; set; }
    }

}
