using System;

namespace AppleAndOrange
{
    /*This is the solution to Hacker Rank problem: Apples and Oranges*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] testingArray1 = { 2, 3, -4 };
            int[] testingArray2 = { 3, -2, -4 };

            countApplesAndOranges(7,10,4,12,testingArray1, testingArray2);
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesByHouse = 0;
            int orangesByHouse = 0;

            foreach(int appleDropDistance in apples)
            {
                if(appleDropDistance + a >= s && appleDropDistance + a <= t)
                {
                    applesByHouse++;
                }
            }

            foreach (int orangeDropDistance in oranges)
            {
                if (orangeDropDistance + b <= t && orangeDropDistance + b >= s)
                {
                    orangesByHouse++;
                }
            }

            Console.WriteLine(applesByHouse);
            Console.WriteLine(orangesByHouse);
        }
    }
}
