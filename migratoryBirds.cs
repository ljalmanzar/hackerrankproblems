using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        // array to keep track
        int[] seen = new int[5];
        int max = 0;
        int maxType = 0;
        
        foreach (var ndx in ar){
          seen[ndx-1]++;
          if(seen[ndx-1]>max || (seen[ndx-1]==max && ndx<maxType)){
            max = seen[ndx-1];
            maxType = ndx;
          }
        }
        
        return maxType;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}