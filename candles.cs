using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        // Complete this function
        int occurrencesOfMax = 0;
        int max = 0;
        
        foreach (int i in ar)
        {
          if (i > max)
          {
            max = i;
            occurrencesOfMax = 1;
          }
          else if(i == max)
          {
            occurrencesOfMax++;
          }
          else
          {
            // continue loop
          }
        }
        
        return occurrencesOfMax;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}