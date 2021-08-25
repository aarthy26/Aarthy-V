using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_demo1
{
  public abstract class Absclass
    {
        protected int Mynumber;
        public abstract int Number { get; set; }    //get and set accessors
    }
    class Absderived:Absclass
    {
        public override int Number
        {         //Implementing abstract properties
            get
            {
                return Mynumber;
            }
            set
            {
                Mynumber = value;
            }

        }
    }
}
