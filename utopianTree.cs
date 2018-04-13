using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int utopianTree(int n)
    {
        int height = 1;

        for (int ndx = 0; ndx < n; ndx++)
        {
            if ((ndx + 2) % 2 == 0)
                height *= 2;
            else
                height++;
        }

        return height;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = utopianTree(n);
            Console.WriteLine(result);
        }
    }
}