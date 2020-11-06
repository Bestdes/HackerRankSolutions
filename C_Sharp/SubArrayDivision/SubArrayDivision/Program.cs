using System;
using System.Collections.Generic;
using System.Linq;

namespace SubArrayDivision
{
    class Program
    {
        /* This is the solution to the Hacker Rank Challenge: Sub Array Division*/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> testingList = new List<int>() { 4, 5, 4, 5, 1, 2, 1, 4, 3, 2, 4, 4, 3, 5, 2, 2, 5, 4, 3, 2, 3, 5, 2, 1, 5, 2, 3, 1, 2, 3, 3, 1, 2, 5};
            int testingD = 18;
            int testingM = 6;
            Console.WriteLine(birthday(testingList, testingD, testingM));
        }

        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            int barSectionCount = 0;
            int numberOfways = 0;
            List<int> summationList = new List<int>();

            for(int i = 0; i < s.Count; i++)
            {
                summationList.Clear();

                for(int j = i; summationList.Sum() <= d && j < s.Count; j++)
                {
                    summationList.Add(s[j]);

                    barSectionCount = summationList.Count;

                    if(barSectionCount == m)
                    {
                        if(summationList.Sum() == d)
                        {
                            numberOfways++;
                        }
                    }
                }
            }
            return numberOfways;
        }
    }
}
