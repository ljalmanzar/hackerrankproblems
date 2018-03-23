using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string[] nk = Console.ReadLine().Split();
            string[] prices_temp = Console.ReadLine().Split(' ');
            int[] prices = Array.ConvertAll(prices_temp, Int32.Parse);
            int charged = Convert.ToInt32(Console.ReadLine());

            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            //find what anna should be charged
            int annaPrice = 0;
            for (int ndx = 0; ndx < prices.Length;ndx++){
                //if it is not the item she didn't eat, add to total
                if (ndx != k)
                    annaPrice += prices[ndx];
            }
            annaPrice /= 2;

            // check if anna actual price matches charged price
            if (annaPrice == charged){
                Console.WriteLine("Bon Appetit");
            }
            else{
                Console.WriteLine(charged - annaPrice);   
            }
        }
    }
}