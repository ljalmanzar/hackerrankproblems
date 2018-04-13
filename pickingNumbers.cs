using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int pickingNumbers(int[] a)
    {
        // sort array for easy counting
        Array.Sort(a);

        // to keep track of largest size
        int max = 0;
        int currentCount = 0;

        // cycle through
        int aNdx = 0;
        int nextNdx = 0;
        bool keepCounting = true;
        bool nextNdxUpdated = false;
        int countingNdx = 0;

        while (aNdx < a.Length){
            //check if values are eligible
            while (keepCounting){
                if (countingNdx < a.Length && Math.Abs(a[aNdx] - a[countingNdx]) <= 1)
                {
                    //if number has changed, update next place to check
                    if (nextNdxUpdated == false && Math.Abs(a[aNdx] - a[countingNdx]) == 1)
                    {
                        nextNdx = countingNdx;
                        nextNdxUpdated = true;
                    }

                    currentCount++;
                    countingNdx++;
                }
                else {
                    keepCounting = false;
                    if (!nextNdxUpdated)
                        nextNdx = countingNdx;
                }
            }

            if (currentCount > max)
                max = currentCount;

            currentCount = 0;
            aNdx = nextNdx;
            countingNdx = aNdx;
            nextNdxUpdated = false;
            keepCounting = true;
        }

        return max;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int result = pickingNumbers(a);
        Console.WriteLine(result);
    }
}
