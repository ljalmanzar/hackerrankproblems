using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int solve(int n, int p)
    {
        int flips = 0;
        // determine whether to start from back or end
        if ((p-1)<(n-p)){
            flips = (p - 1) / 2;
            if ((p - 1) % 2 != 0)
                flips++;
        }
        else{
            flips = (n - p) / 2;
            if ((n - p) % 2 != 0 && n % 2 == 0)
                flips++;
        }

        return flips;
    }

    static void Main(String[] args)
    {
        int n = 18183;
        int p = 18042;
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}