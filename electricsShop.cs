using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int getMoneySpent(int[] keyboards, int[] drives, int s)
    {
        // sort arrays
        Array.Sort(keyboards);
        Array.Reverse(keyboards);

        Array.Sort(drives);
        Array.Reverse(drives);

        int maxSpent = -1;
        int drivendx = 0;

        for (int keyboardndx = 0; keyboardndx < keyboards.Length; keyboardndx++){

            drivendx = 0;
            while(keyboards[keyboardndx]+drives[drivendx] > s && drivendx+1 != drives.Length){
                drivendx++;
            }

            if (keyboards[keyboardndx] + drives[drivendx] > maxSpent && keyboards[keyboardndx] + drives[drivendx] <= s)
                maxSpent = keyboards[keyboardndx] + drives[drivendx];
        }

        return maxSpent;
    }

    static void Main(String[] args)
    {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int n = Convert.ToInt32(tokens_s[1]);
        int m = Convert.ToInt32(tokens_s[2]);
        string[] keyboards_temp = Console.ReadLine().Split(' ');
        int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
        string[] drives_temp = Console.ReadLine().Split(' ');
        int[] drives = Array.ConvertAll(drives_temp, Int32.Parse);
        //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
        int moneySpent = getMoneySpent(keyboards, drives, s);
        Console.WriteLine(moneySpent);
    }
}