using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class Program
    {
        /* This is the solution to the Hacker Rank Challenge: Between Two Sets*/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> first = new List<int>() { 2, 4 };
            List<int> second = new List<int>() { 16, 32, 96 };

            Console.WriteLine(getTotalX(first, second));
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            int lowestB = b.Min();
            List<int> setOfFactors = new List<int>();
            int intInQuestion = lowestB;

            while(intInQuestion > 0)
            {
                bool isFactorOfSetB = b.All(numInB => numInB % intInQuestion == 0);
                bool allInSetA_AreFactors = a.All(numInA => intInQuestion % numInA == 0);

                if(isFactorOfSetB && allInSetA_AreFactors)
                {
                    if(!setOfFactors.Contains(intInQuestion))
                    {
                        setOfFactors.Add(intInQuestion);
                    }
                }
                intInQuestion--;
            }
            int finalOutput = setOfFactors.Count;
            return finalOutput;
        }
    }
}
