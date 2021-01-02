using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] testing = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            Console.WriteLine(sockMerchant(9, testing));
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int totalNumOfSockPairs = 0;
            Dictionary<int, int> sockCollection = new Dictionary<int, int>();

            foreach (int sock in ar)
            {
                if(sockCollection.ContainsKey(sock))
                {
                    sockCollection[sock]++;
                }
                else
                {
                    sockCollection.Add(sock, 1);
                } 
            }

            foreach(KeyValuePair<int, int> sockCount in sockCollection)
            {
                if(sockCount.Value > 1)
                {
                    totalNumOfSockPairs += sockCount.Value / 2;
                }
            }


            return totalNumOfSockPairs;
        }
    }
}
