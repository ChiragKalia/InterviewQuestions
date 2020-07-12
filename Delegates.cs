using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    //Delegates are primarily used for communication between multiple objects. 
    //Their usage in .NET is for Callbacks, Sub/Pub model.
    public class Delegates
    {
        public Delegates()
        {
            MyClass myClass = new MyClass();
            myClass.LongRunning(CallBack);
        }
        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }

    }
    public class MyClass
    {
        //Instead of Creating a new delegate, We can use built in delegate Action
        //public delegate void CallBack(int i); 
        public void LongRunning(Action<int> obj)   
        {
            for(int i=0; i<100; i++)
            {
                obj(i);
            }
        }
    }
}
