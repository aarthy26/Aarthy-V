using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_demo
{
   [Serializable]
    public class student
    {
        public int regno;
        public string Name;
       
        public void display()
        {
            Console.WriteLine("Regno:" + regno + "\n" + "Name:" + Name);
        }
    }

    public class serializationdemo
    {
        static void Main(string[] args)
        {
            student s = new student(); 
            s.regno = 1001;
            s.Name = "Jency";
            BinaryFormatter f = new BinaryFormatter();  //covert the object into binaryformat
            Stream st = new FileStream(@"E:\avelayut\Documents\New folder", FileMode.Create, FileAccess.Write);   //(create the filestream)filestream object is used to open the file
            f.Serialize(st, s);   //serialize the object
            st.Close();

            st=new FileStream(@"E:\avelayut\Documents\New folder", FileMode.Open, FileAccess.Read);
            student obj = (student)f.Deserialize(st);    //deserialize the object
            st.Close();
            obj.display();
            Console.ReadLine();
        }
    }

}

   
