using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Man : Person
    {
        public string Hobby { get; set; }
    }

    public class Class1
    {
        public static void Main22(string[] args)
        {
            Object obj = new Object();
            obj = 10; // Boxing

            int i = (int)obj; // Unboxing
            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);// Boxing
            int firstElement = (int)arrayList[0]; // Unboxing

            List<int> list = new List<int>();

            Object myObject = new object();
            myObject = 10;
            myObject = "Srikanth";

            int x = (int)myObject;

            if (myObject is int)
            {
                //int myInt = (int)myObject;
                //int myInt = Convert.ToInt32(myObject)
                //int myInt = myObject as int; // this is only for reference type
                Person person = new Person();
                Man man = new Man();
                person =man;

                Man man2=new Man();
                man2 = person as Man;
            }
            else if (myObject is string)
            {
                string myString = (string)myObject;
            }
        }
    }
}
