using System;
using System.Collections.Generic;
using System.Linq;

namespace ADS
{
    class ExerciseTwo
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter desired sequence of numbers. Separate them with blank spaces.\n");
            var numbList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numbCount = numbList.Count();
            int currValue = numbList[0];
            int currCount = 1;
            int maxCount = 1;
            int maxValue = currValue;
            for (int i = 1; i < numbCount; i++)
            {
                if (numbList[i] == currValue)
                {
                    currCount++;
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                        maxValue = currValue;
                    }
                }
                else
                {
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                        maxValue = currValue;
                    }
                    currCount = 1;
                    currValue = numbList[i];
                }
            }
            Console.WriteLine("\n\nThe number {0} is present {1} times in the entered sequence.", maxValue, maxCount);
            List<int> jomama = new List<int>();
            Console.WriteLine("\n\n\nNew list contains the following items:");
            for (int j = 0; j < maxCount; j++)
            {
                jomama.Add(maxValue);
                Console.WriteLine(jomama[0]);
            }
            
        }
    }
}
