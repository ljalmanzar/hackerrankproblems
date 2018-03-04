using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp,Int32.Parse);
        string word = Console.ReadLine();
        int length = word.Length;
        int width = 0;
        
        //enter all letters and corresponding heights in hashtable
        Dictionary<char,int> letterHeights = new Dictionary<char,int>();
        
        for(int i = 0; i<26; i++)
        {
          letterHeights.Add((Convert.ToChar(i+97)),h[i]);
        }
        
        foreach(char c in word)
        {
          if(letterHeights[c] > width)
          {
            width = letterHeights[c];
          }
        }
        
        Console.WriteLine(length*width);
    }
}