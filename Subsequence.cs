using System;

namespace Subsequence
{
	internal class Subsequence
	{
		static void Main(string[] args)
		{
			int starnNumberFromSequence = 5;
			int step = 7;
			int maxNumberFromSequence = 96;

			for (int i = starnNumberFromSequence; i <= maxNumberFromSequence; i += step)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}
