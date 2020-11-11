using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MigratoryBirds
{
    class Program
    {
        /* This is the solution to the Hacker Rank Challenge: Migratory Birds */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> testingList = new List<int>() { 1, 4, 4, 4, 5, 3 };
            Console.WriteLine(migratoryBirds(testingList));
        }

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            int finalBirdID = 0;
            Dictionary<int,int> oneTimeList = new Dictionary<int, int>();

            foreach (int bird in arr)
            {
                if (oneTimeList.ContainsKey(bird)){
                    oneTimeList[bird]++;
                }
                else
                {
                    oneTimeList.Add(bird, 1);
                }
            }

            finalBirdID = (from n in oneTimeList
                           where n.Value == oneTimeList.Values.Max()
                           select n.Key).Min(); 

            return finalBirdID;
        }
    }
}
