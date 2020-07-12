using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    public abstract class AbstractClassVirtualMethod
    {
        public abstract void DefaultMethod();
        public virtual void VirtualMethodCanHaveImplementation()
        {
            Console.WriteLine("Default Implementation"); 
        }
    }
    class B : AbstractClassVirtualMethod
    {
        public override void DefaultMethod()
        {
            throw new NotImplementedException();
        }
        //We can opt not to override a virtual method but we have to implement 
        // abstract methods.
    }
}
