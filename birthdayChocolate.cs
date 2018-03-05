using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int[] s, int d, int m){
        // indicies to keep track
        int frontNdx = 0;
        // setting the backndx to the how many blocks need to be counted
        int backNdx = m-1;
        
        // counting index 
        int innerFrontNdx;
        
        // to hold the sum of any given pieces & total output
        int currentSum = 0;
        int output = 0;
        
        while( !(backNdx>(s.Length)-1) ){
          // sum up the numbers
          innerFrontNdx = frontNdx;
          
          currentSum = 0;
          while(innerFrontNdx<=backNdx){
            currentSum += s[innerFrontNdx];
            innerFrontNdx++;
          }
          
          // check if sum works
          if (currentSum == d)
            output++;
          
          frontNdx++;
          backNdx++;
        }
        
        return output;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}
