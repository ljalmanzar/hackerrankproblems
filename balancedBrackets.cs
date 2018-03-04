using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
  
    public static bool checkBalance(string inputStr){
     
     char tempHolder;
     Stack<char> charHolder = new Stack<char>();
     for(int ndx = 0; ndx<inputStr.Length;ndx++)
          {
            tempHolder = inputStr[ndx];
            switch(tempHolder)
            {
              case '{':
                charHolder.Push('}'); 
                break;
              case '(':
                charHolder.Push(')'); 
                break;
              case '[':
                charHolder.Push(']'); 
                break;
              default:
                if (charHolder.Count == 0 || tempHolder != charHolder.Peek())
                {
                  return false;
                }
                charHolder.Pop();
                break;
            }
          }     
      return true;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
          string expression = Console.ReadLine();
          string msg;
			    msg = checkBalance(expression)? "YES" : "NO";
          Console.WriteLine(msg);
        }
    }
}

