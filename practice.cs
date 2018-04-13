using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    /*
     * Complete the function below.
     */
    static int countDuplicates(int[] numbers)
    {
        int duplicates = 0;

        // sort numbers to put duplicates next to eachother
        Array.Sort(numbers);

        // iterate through to count number of duplicates
        int mainNdx = 0;
        int comparisonNdx = 0;

        while (mainNdx < numbers.Length)
        {
            // move comparison ndx to next number, if at end of array..break loop
            if (comparisonNdx + 1 < numbers.Length)
                comparisonNdx++;
            
            // check for duplicates
            if (numbers[mainNdx] == numbers[comparisonNdx])
                duplicates++;

            // find next unique num by skipping the rest of the same duplicate
            while (comparisonNdx + 1 < numbers.Length && numbers[mainNdx] == numbers[comparisonNdx])
                comparisonNdx++;

            // update mainndx
            mainNdx = comparisonNdx;
        }
    }

    static void Main(String[] args)
    {
        string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
        TextWriter tw = new StreamWriter(@fileName, true);

        int numbersCnt = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[numbersCnt];

        for (int numbersItr = 0; numbersItr < numbersCnt; numbersItr++)
        {
            int numbersItem = Convert.ToInt32(Console.ReadLine());
            numbers[numbersItr] = numbersItem;
        }

        int res = countDuplicates(numbers);

        tw.WriteLine(res);

        tw.Flush();
        tw.Close();
    }
}