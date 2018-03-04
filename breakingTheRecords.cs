using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    // Complete this function
    static int[] breakingRecords(int[] score) {
      int maxScore = score[0];
      int leastScore = score[0];
      
      //ndx 0 = change in max score; ndx 1 = change in least
      int[] changeArray = {0,0};
      
      foreach(var ndx in score){
        // check if score of current score is larger or smaller than current records, if so... update
        if (ndx > maxScore){
          maxScore = ndx;
          changeArray[0]++;
        }
        else if (ndx < leastScore){
          leastScore = ndx;
          changeArray[1]++;
        }
        else {
          // won't be needed in this case. but for future dev
        }
      }

      return changeArray;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp,Int32.Parse);
        int[] result = breakingRecords(score);
        Console.WriteLine(String.Join(" ", result));
    }
}
