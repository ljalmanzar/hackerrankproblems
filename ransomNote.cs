using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        
        bool canPrint = true;
        Dictionary<String, int> wordFreq = new Dictionary<String, int>();

        //add possible words to dictionary
        foreach(string s in magazine)
        {
            if(!wordFreq.ContainsKey(s))
            {
                wordFreq.Add(s, 1);
            }
            else
            {
                wordFreq[s] = wordFreq[s] + 1;
            }
        }
        
        // check dictionary for words
        foreach(string s in ransom)
        {
          if(!wordFreq.ContainsKey(s))
          {
            canPrint = false;
            break;
          }
          else
          {
            //if value is 1, remove from diction, else subtract
            if(wordFreq[s] == 1)
            {
              wordFreq.Remove(s);
            }
            else
            {
              wordFreq[s] = wordFreq[s] - 1;
            }
          }
        }
        
        string msg;
			  msg = canPrint ? "Yes" : "No";
        Console.WriteLine(msg);
    }
}