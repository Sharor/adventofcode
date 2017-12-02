using System;
using System.Collections.Generic;
using System.Text;

namespace day1
{
	public class AdvancedCaptchaEvaluator
	{
		public int EvaluateCaptcha(string puzzle)
		{
			return CheckConsecutiveDigits(puzzle); 
		}

		public int CheckConsecutiveDigits(string puzzle)
		{
			int consecutiveValue = 0;
			int midway = puzzle.Length / 2; 

			for (int i = 0; i < puzzle.Length; i++)
			{
				if (i != puzzle.Length)
				{
					if(i+midway>puzzle.Length-1)
					{
						if(puzzle[i]==puzzle[midway+i-puzzle.Length])
							consecutiveValue += (int)Char.GetNumericValue(puzzle[i]);
					}
					else
					{
						if(puzzle[i]==puzzle[i+midway])
							consecutiveValue += (int)Char.GetNumericValue(puzzle[i]);
					}
						
				}
					
			}
			return consecutiveValue;
		}
	}
}
