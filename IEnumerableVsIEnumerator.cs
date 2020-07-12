using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    public class IEnumerableVsIEnumerator
    {
        /* The major difference between IEnumerable and IEnumerator is that IEnumerator
         * keeps track of the current iterator position but IEnumerable does not
         asd*/
        List<int> primeNumbers = new List<int> { 1, 3, 5, 7, 11, 13, 17 };
        public IEnumerableVsIEnumerator()
        {
            //IEnumerable<int> ienum = (IEnumerable<int>)primeNumbers;
            //foreach(int i in ienum)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //While iterating using IEnumerator is difficult but IEnumerable internally uses IEnumerator.
            IEnumerator<int> enumerator = primeNumbers.GetEnumerator();
            Iterate0to9(enumerator);
            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.ToString());
            //}
                
        }

        public void Iterate0to9(IEnumerator<int> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
                if (i.Current >= 10)
                {
                    /* When we pass i to the other method, This method keeps track 
                     * of the current element being traversed and does not repeat them here
                     * This would not have been possible with IEnumerable 
                     * and it would have repeated the elements*/
                    Iterate10andAbove(i);
                }
            }
        }
        public void Iterate10andAbove(IEnumerator<int> i)
        {
            while(i.MoveNext())
                Console.WriteLine(i.Current);
        }
    }
}
