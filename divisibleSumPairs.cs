using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int divisibleSumPairs(int n, int k, int[] ar) {
        // Complete this function
        
        int totalCombos = 0;
        // array to keep track of modulo results
        int[] remainderArr = new int[k];
        
        // find modulo values for all elements
        int remainder;
        foreach(var ndx in ar){
          remainder = ndx % k; 
          remainderArr[remainder]++;
        }
        
        // find combinations
        // for module 0.. 
        totalCombos = (remainderArr[0]*(remainderArr[0]-1))/2;
        
        // for the rest 
        for (int i=1; i<=k/2 && i!=k-i;i++){
            totalCombos+=remainderArr[i]*remainderArr[k-i];
          }
          
        // case of if even 
        if(k%2 == 0){
          totalCombos+=(remainderArr[k/2]*(remainderArr[k/2]-1))/2;
        }
        
      return totalCombos;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}


