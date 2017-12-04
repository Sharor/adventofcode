using System;
using System.Collections.Generic;
using System.Text;

namespace day3
{
	public class Spiral
	{
		Coordinates[,] grid;
		int origin;
		int gridsize;
		enum Direction { up, down, left, right }

		public Spiral(int size)
		{
			gridsize = (int)Math.Sqrt(size);
			grid = new Coordinates[gridsize, gridsize];
			CreateEmptyGrid(size);
		}

		void CreateEmptyGrid(int size)
		{
			origin = gridsize / 2;
			grid[origin, origin] = new Coordinates(origin, origin, 1);
			grid[origin + 1, origin] = new Coordinates(origin + 1, origin, 2);
			grid[origin + 1, origin - 1] = new Coordinates(origin + 1, origin - 1, 3);
			int stepsInCurrentSpiral = 2;
			int stepcounter = 0;
			Direction current = Direction.left;
			Coordinates previous = grid[origin + 1, origin - 1];

			///Problem is you only count steps for one side, not a whole "spiral". Change stepcoutner and handle edge case around1. 
			for (int i = 4; i <= size; i++)
			{
				switch (current)
				{
					case Direction.up:
						grid[previous.X, previous.Y - 1] = new Coordinates(previous.X, previous.Y-1, i);
						previous = grid[previous.X, previous.Y - 1];
						break;
					case Direction.down:
						grid[previous.X, previous.Y + 1] = new Coordinates(previous.X, previous.Y + 1, i);
						previous = grid[previous.X, previous.Y + 1];
						break;
					case Direction.right:
						grid[previous.X + 1, previous.Y] = new Coordinates(previous.X + 1, previous.Y, i);
						previous = grid[previous.X + 1, previous.Y];
						break;
					case Direction.left:
						grid[previous.X - 1, previous.Y] = new Coordinates(previous.X - 1, previous.Y, i);
						previous = grid[previous.X - 1, previous.Y];
						break;
					default:
						break;
				}			

				stepcounter++;
				if (stepcounter == stepsInCurrentSpiral)
				{
					stepcounter = 0;
					if (current == Direction.up)
						current = Direction.left;
					else if (current == Direction.down)
						current = Direction.right;
					else if (current == Direction.left)
						current = Direction.down;
					else if (current == Direction.right&&i!=size)
					{
						i++;
						grid[previous.X + 1, previous.Y] = new Coordinates(previous.X + 1, previous.Y, i);
						previous = grid[previous.X + 1, previous.Y];
						stepcounter++;
						current = Direction.up;
						stepsInCurrentSpiral+=2;
					}



				}
			}
		}

		public int CalculateSteps(int number)
		{
			foreach (Coordinates coordinate in grid)
				if (coordinate.Value == number)
					return Math.Abs(origin - coordinate.X) + Math.Abs(origin - coordinate.Y);
			return 0;
		}

		public void PrintGrid(int size)
		{
			Console.WriteLine("------");
			Console.WriteLine("Grid");
			Console.WriteLine("------");
			for (int j = 0; j < gridsize; j++)
			{
				for (int i = 0; i < gridsize; i++)
				{
					Console.Write(grid[i, j].Value + " ");
				}
				Console.WriteLine();
			}
		}
	}

	public class Coordinates
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		public int Value { get; set; }

		public Coordinates(int x, int y, int value)
		{
			X = x;
			Y = y;
			Value = value;
		}
	}
}
