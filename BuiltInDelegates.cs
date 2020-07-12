using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace InterviewQuestions
{
    public class BuiltInDelegates
    {
        //.NET FRAMEWORK HAS THREE TYPES OF BUILT IN DELEGATES.
        //Func, Action and Predicate.
        //Func - Takes zero, one or more parameters and returns a value(with it's out param) 
        //Action- Takes zero, one or more params and doesn't return anything 
        //Predicate - It's a special kind of func and it represents a method that contains a set of criteria mostly defined inside an if condition and checks whether the passed parameter meets those criteria or not. It takes one input parameter and returns a boolean - true or false.

        public BuiltInDelegates()
        {
            PredicateImplementation();
        }
        public void PredicateImplementation()
        {
            //Normal Predicate Implementation
            Predicate<int> matchNumbers = DoesNumberMatch;
            Console.WriteLine(matchNumbers(1));

            //Predicate with Anonymous Method 
            Predicate<int> matchNumbersAnon = delegate (int a) { return a == 1 ? true : false; };
            Console.WriteLine(matchNumbersAnon(2));
            //Predicate with Lambda Expressions
            Predicate<int> matchNumbersLambda = (a) => a == 1 ? true : false;
            Console.WriteLine(matchNumbersLambda(1));
        }
        public void ActionImplementation()
        {
            //Normal Action Implementation
            Action<int, int> Addition = PrintNumbers;
            Addition(10, 10); 
            //Action with Anonymous Method
            Action<int, int> AdditionAnonymous = delegate (int param1, int param2) { 
                Console.WriteLine(param1+param2); };
            AdditionAnonymous(10, 10);
            //Action with Lambda Expressions
            Action<int, int> AdditionLambda = (param1, param2) => Console.WriteLine(param1+param2);
        }
        public void FuncImplementation()
        {
            //Normal Func Implementation
            Func<int, int, int> Addition = AddNumbers;
            Console.WriteLine(Addition(10, 10));

            //Func with Anonymous Method
            Func<int, int, int> AdditionAnonymous = delegate (int param1, int param2) { return param1 + param2; };
            Console.WriteLine(AdditionAnonymous(10, 10));

            //Func with Lambda Expression
            Func<int, int, int> AdditionLambda = (param1, param2) => param1 + param2;
            Console.WriteLine(AdditionLambda(10, 10));
        }
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public void PrintNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public bool DoesNumberMatch(int a)
        {
            int b = 1;
            return a == b ? true : false;
        }
    }
}
