using System;
using System.Collections.Generic;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            int[] arrayOfBirdIDandCount = new int[2];
            int[] finalBirdArray = new int[2];
            int innerLoopCount = 0;
            int numOfBirdType = 0;


            foreach(int bird in arr)
            {
                arrayOfBirdIDandCount[0] = bird;
                
                foreach(int birdID in arr)
                {
                    if (birdID == arrayOfBirdIDandCount[innerLoopCount])
                    {
                        numOfBirdType++;
                        arrayOfBirdIDandCount[1] = numOfBirdType;
                        if(arrayOfBirdIDandCount[1] > finalBirdArray[1])
                        {
                            finalBirdArray[0] = arrayOfBirdIDandCount[0];
                            finalBirdArray[1] = arrayOfBirdIDandCount[1];
                        }
                    }
                    innerLoopCount++;
                }

            }
            return finalBirdArray[0];
        }
    }
}
