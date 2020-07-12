using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    public class ObjectArrays
    {
        //You can create Object arrays in which you can put any primitive and non primitive datatype
        //The usage of Object Arrays is not recommended because we always have to box and unbox it. 
        static ObjectArrays()
        {
            Object[] objArr = new object[3];
            objArr[0] = 1;
            objArr[1] = "String";
            Customer c = new Customer();
            c.ID = 99;
            c.Name = "Chirag";
            objArr[2] = c.ToString();
            foreach(object obj in objArr)
            {
                Console.WriteLine(obj);
            }
        }
        public class Customer { 
            public int ID { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }
    }
}
