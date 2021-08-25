using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plymorphism_demo2
{
   public class Vehicle
    {
        public string Regno;
        public int Modelyear;
        public string Fueltype;
        public Vehicle(string Regno,int Modelyear,string Fueltype)
        {
            this.Regno = Regno;
            this.Modelyear = Modelyear;
            this.Fueltype = Fueltype;
        }
        public virtual void start()
        {
            Console.WriteLine("the vehicle is started");
        }
        public virtual void Move()
        {
            Console.WriteLine("the vechicle is moved");
        }
        public virtual void stop()
        {
            Console.WriteLine("the vechile is stopped");
        }
    }
    public class Car: Vehicle
    {
        public Car(string Regno, int Modelyear, string Fueltype):base( Regno, Modelyear, Fueltype)
        {
            this.Regno = Regno;
            this.Modelyear = Modelyear;
            this.Fueltype = Fueltype;
        }
        public override void start()
        {
            Console.WriteLine("the Car is started");
        }
        public override void Move()
        {
            Console.WriteLine("the Car is moved");
        }
        public override void stop()
        {
            Console.WriteLine("the Car is stopped");
        }
    }
        
}
