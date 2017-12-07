using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
	public class Maze
	{
		int steps = 0;
		int mazeStepper = 0;
		public int[] numbers;
		List<int> testedNumbers = new List<int>();

		void Setup(string puzzle)
		{
			string[] splitLines = puzzle.Split('\n');
			numbers = new int[splitLines.Length];
			for (int i = 0; i < splitLines.Length; i++)
				numbers[i] = int.Parse(splitLines[i]);
			steps = 0;
			mazeStepper = 0;
		}

		public int Escape(string puzzle)
		{
			Setup(puzzle); 
			while (mazeStepper < numbers.Length)
			{
				if (testedNumbers.Contains(numbers[mazeStepper]))
				{
					SimpleIncrement();
				}
				else
				{
					testedNumbers.Add(numbers[mazeStepper]);
					SimpleIncrement();

				}
				steps++;
			}
			return steps;
		}

		void SimpleIncrement()
		{
			numbers[mazeStepper]++;
			mazeStepper += numbers[mazeStepper] - 1;
		}

		public int AdvancedEscape(string puzzle)
		{
			Setup(puzzle);
			while (mazeStepper < numbers.Length||mazeStepper<0)
			{
				if (testedNumbers.Contains(numbers[mazeStepper]))
				{
					AdvancedIncrement();
				}
				else
				{
					testedNumbers.Add(numbers[mazeStepper]);
					AdvancedIncrement();
				}
				steps++;
			}
			return steps;
		}

		void AdvancedIncrement()
		{
			if (numbers[mazeStepper] >= 3)
			{
				numbers[mazeStepper] -= 1;
				mazeStepper += numbers[mazeStepper] + 1;
			}
			else
			{
				numbers[mazeStepper]++;
				mazeStepper += numbers[mazeStepper] - 1;				
			}
		}
	}
}
