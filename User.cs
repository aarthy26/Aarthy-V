using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_serialization_xml
{
  public  class User
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return "firstname:" + firstname + "lastname:" + lastname + "BirthDate:" + BirthDate;
        }
    }
}
