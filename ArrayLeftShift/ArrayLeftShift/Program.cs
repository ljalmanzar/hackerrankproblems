using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
	static void Main(String[] args)
	{
		string[] tokens_n = Console.ReadLine().Split(' ');
		int n = Convert.ToInt32(tokens_n[0]); // num of ints
		int k = Convert.ToInt32(tokens_n[1]); // num of rotations
		string[] a_temp = Console.ReadLine().Split(' ');
		int[] a = Array.ConvertAll(a_temp, Int32.Parse);

		int indicies2Moves = k % n;

		int[] bufferHolder = new int[indicies2Moves];

		for (int ndx = 0; ndx < indicies2Moves; ndx++)
		{
			bufferHolder[ndx] = a[ndx];
		}

		int replaceIndex = 0;
		while (replaceIndex < (n - indicies2Moves))
		{
			a[replaceIndex] = a[replaceIndex + indicies2Moves];
			replaceIndex++;
		}

		int bufferIndex = 0;
		while (replaceIndex < n)
		{
			a[replaceIndex] = bufferHolder[bufferIndex];
			replaceIndex++;
			bufferIndex++;
		}

		for (int ndx = 0; ndx < a.Length; ndx++)
		{
			Console.Write("{0} ", a[ndx]);
		}
	}
}