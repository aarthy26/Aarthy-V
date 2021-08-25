using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>()
            {
            new Employee { firstname = "Aishu", lastname = "Mary", id = 10326, dept = "application support", qualification = "B.tech",salary=20000 },
            new Employee { firstname = "Jaya", lastname = "palani", id = 10327, dept = "accountance", qualification = "M.com",salary=10000 },
            new Employee { firstname = "Priya", lastname = "Ramasamy", id = 10328, dept = "Quality", qualification = "B.Tech",salary=25000 },
            new Employee { firstname = "Anitha", lastname = "Arumugam", id = 10329, dept = "networking", qualification = "B.E",salary=15000 },
            new Employee { firstname = "Saranya", lastname = "prakash", id = 10330, dept = "security", qualification = "B.E",salary=28000 },
            new Employee { firstname = "Divya", lastname = "krishnan", id = 10331, dept = "testing", qualification = "B.E",salary=30000 }
        };
            //basic query syntax
            var records = from emp in employee
                          orderby emp.firstname
                          //orderby emp.qualification
                          // group emp by emp.qualification
                          //orderby emp.firstname descending
                          //where emp.salary<20000
                          select emp;
           
            //  foreach(var qualification in records)
            //{
            //    Console.WriteLine("qualification group", qualification.Key);
            //    foreach (Employee emp in qualification)
            //    {
            //        Console.WriteLine("firstname", emp.firstname);
            //    }
            //}
            foreach (var record in records)
            {
                Console.WriteLine(record.firstname + "-" + record.qualification);
            }
            Console.ReadLine();

            //basic method syntax
            //var records1 = employee.Select(s => s);
            //Console.WriteLine("using the method syntax\n ***************");

            //foreach (var record in records1)
            //{
            //    Console.WriteLine(record.firstname + "-" + record.qualification);
            //}
        }
    }
}
