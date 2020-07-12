using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class ExceptionInFinallyBlock
    {
        public ExceptionInFinallyBlock()
        {
            Product(); //Application crashes here unless we keep it in a try catch block.
        }
        public void Product()
        {
            try
            {
                //If try block exception is not handled in catch block and we get an exception in finally block then it will be lost.
                throw new Exception("Try block exception");
            }
            finally
            {
                //If Finally block encounters an exception then it should be handled by the calling method. 
                Console.WriteLine("Finally Block Exception");
                int n = Convert.ToInt32("saddfsf");

            }
        }
    }
}
