using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{


    /*
     * Complete the catAndMouse function below.
     */
    static string catAndMouse(int x, int y, int z)
    {
        // calculate distances
        int catADistance = Math.Abs(z - x);
        int catBDistance = Math.Abs(z - y);

        if (catADistance < catBDistance)
            return "Cat A";
        else if (catADistance > catBDistance)
            return "Cat B";
        else
            return "Mouse C";
    }


    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            tw.WriteLine(result);
        }

        tw.Flush();
        tw.Close();
    }
}