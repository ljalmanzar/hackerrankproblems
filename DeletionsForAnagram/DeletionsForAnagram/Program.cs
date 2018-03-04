using System;

namespace DeletionsForAnagram
{
    class MainClass
    {
        /*how many deletions to make a an anagram of b. anagram is when a string
        can be permutated to exist in b*/
        public static void Main(string[] args)
        {
            string a = "fsdghfiylasvfgilyewhlfdskjb";
            string b = "nucwopppppaexfgysaguximrgoifwuyag";

            int[] freqHolder = new int[26];
            int removals = 0;

            foreach(var ndx in a){
                freqHolder[ndx - 'a']++; 
            }

            foreach (var ndx in b)
			{
				freqHolder[ndx - 'a']--;
			}

            foreach (var ndx in freqHolder)
            {
                removals += Math.Abs(ndx);
            }

            Console.WriteLine(removals);
        }
    }
}
