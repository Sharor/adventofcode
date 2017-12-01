using System;
using System.Collections.Generic;
using System.Text;

namespace day1
{
	public class CaptchaEvaluator
	{
		public int EvaluateCaptcha(string puzzle)
		{
			return CheckConsecutiveDigits(puzzle) + CheckEndMatchFirst(puzzle);  
		}

		public int CheckConsecutiveDigits(string puzzle)
		{
			int consecutiveValue = 0;
			for (int i = 0; i < puzzle.Length; i++)
			{
				if (i != puzzle.Length-1)
					if (puzzle[i] == puzzle[i + 1])
						consecutiveValue += (int)Char.GetNumericValue(puzzle[i]);
			}
			return consecutiveValue;
		}

		public int CheckEndMatchFirst(string digits)
		{
			if (digits[0] == digits[digits.Length - 1])
				return (int)Char.GetNumericValue(digits[0]);
			else
				return 0; 
		}
	}
}
