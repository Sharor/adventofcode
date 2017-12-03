using System;
using System.Collections.Generic;
using System.Text;

namespace day2
{
	public class AdvancedChecksumCalculator
	{
		public int RowChecksum(string puzzle)
		{
			string[] splitNumbers = puzzle.Split('\t');
			int[] numbers = Array.ConvertAll(splitNumbers, int.Parse);

			foreach(int number in numbers)
				foreach(int second in numbers)
					if(number!= second && number%second==0)
					{
						if (second > number)
							return second / number;
						else
							return number / second;
					}
			return 0;
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
