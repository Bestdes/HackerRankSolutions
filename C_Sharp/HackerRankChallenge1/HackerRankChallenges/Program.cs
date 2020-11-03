using System;
using System.Threading;

namespace HackerRankChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(timeConversion("12:05:45AM"));
        }

        /*This is Time Conversion Challenge*/
        static string timeConversion(string s)
        {
            string strippedString = s.Remove(8);
            string firstTwo = s.Substring(0, 2);
            string lastTwo = s.Substring(8, 2);
            string finalString;

            int tobeAdded;
            bool isNum = int.TryParse(firstTwo, out tobeAdded);

            if (lastTwo == "PM")
            {

                if(tobeAdded < 12)
                {
                    tobeAdded += 12;
                }
                    finalString = strippedString.Remove(0, 2).Insert(0, tobeAdded.ToString());
                    return finalString;
            }
            else
            {
                if(tobeAdded == 12)
                {
                   finalString = strippedString.Remove(0, 2).Insert(0, "00");
                   return finalString;
                }

                finalString = strippedString;
                return finalString;
            }
        }
    }
}
