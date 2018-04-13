using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string angryProfessor(int k, int[] a)
    {
        int peopleOnTime = 0;
        // sort array to put late people up front
        Array.Sort(a);
        Array.Reverse(a);

        foreach(var ndx in a){
            if (ndx <= 0)
                peopleOnTime++;
        }

        if (peopleOnTime >= k)
            return "NO";
        else
            return "YES";

    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string result = angryProfessor(k, a);
            Console.WriteLine(result);
        }
    }
}