using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int beautifulDays(int i, int j, int k)
    {
        int ogNum = 0;
        int reversedNum = 0;
        int numOfBeautifulDays = 0;

        for (int ndx = i; ndx <= j; ndx++)
        {
            ogNum = ndx;
            //reverse number
            reversedNum = 0;
            while (ogNum > 0)
            {
                reversedNum = reversedNum * 10 + ogNum % 10;
                ogNum /= 10;
            }
            //check difference
            ogNum = ndx;
            if (Math.Abs(ogNum - reversedNum) % k == 0)
                numOfBeautifulDays++;
        }

        return numOfBeautifulDays;
    }

    static void Main(String[] args)
    {
        string[] tokens_i = Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(tokens_i[0]);
        int j = Convert.ToInt32(tokens_i[1]);
        int k = Convert.ToInt32(tokens_i[2]);
        int result = beautifulDays(i, j, k);
        Console.WriteLine(result);
    }
}
