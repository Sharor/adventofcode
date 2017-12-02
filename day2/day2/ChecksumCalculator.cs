using System;
using System.Collections.Generic;
using System.Text;

namespace day2
{
	public class ChecksumCalculator
	{
		public int RowChecksum(string puzzle)
		{
			string[] splitNumbers = puzzle.Split('\t');
			int[] numbers = Array.ConvertAll(splitNumbers, int.Parse);

			int max = 0;
			int min = numbers[0]; 
			foreach(int number in numbers)
			{
				if (number < min)
					min = number;
				if (number > max)
					max = number;					
			}
			return max - min;
		}

		public int TotalChecksum(string puzzle)
		{
			int total = 0;
			string[] splitLines = puzzle.Split('\n');
			foreach(string line in splitLines)
			{
				total += RowChecksum(line); 
			}
			return total;
		}
	}
}
