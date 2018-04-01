using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int countingValleys(int n, string s)
    {
        int depthTracker = 0;
        int valleys = 0;

        foreach (var ndx in s){
            if (ndx == 'U'){
                depthTracker++;
            }
            else {
                depthTracker--;
                if (depthTracker == -1)
                    valleys++;
            }
        }

        return valleys;
    }

    static void Main(String[] args)
    {
        int n = 8;
        string s = "UDDDUDUU";
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
