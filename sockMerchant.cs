using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int sockMerchant(int n, int[] ar)
    {
        // array to keep track of current colors 
        int[] sockColors = new int[100];
        int numOfPairs = 0;

        for (int ndx = 0; ndx < ar.Length; ndx++){
            // if value in array spot 1, add one to num of pairs and reset
            if (sockColors[ar[ndx]-1] == 1 ){
                numOfPairs++;
                sockColors[ar[ndx]-1] = 0;
            }
            else{
                sockColors[ar[ndx]-1] = 1;
            }
        }
        return numOfPairs;
    }

    static void Main(String[] args)
    {
        int n = 9;
        int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}