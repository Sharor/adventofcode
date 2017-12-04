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

		}

		public void CreateEmptyGrid(int size)
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
						grid[previous.X, previous.Y - 1] = new Coordinates(previous.X, previous.Y - 1, i);
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
					else if (current == Direction.right && i != size)
					{
						i++;
						grid[previous.X + 1, previous.Y] = new Coordinates(previous.X + 1, previous.Y, i);
						previous = grid[previous.X + 1, previous.Y];
						stepcounter++;
						current = Direction.up;
						stepsInCurrentSpiral += 2;
					}



				}
			}
		}

		void SetupBasicGrid(int size)
		{
			gridsize = (int)Math.Sqrt(size);
			grid = new Coordinates[gridsize, gridsize];
			for (int i = 0; i < gridsize; i++)
			{
				for (int j = 0; j < gridsize; j++)
				{
					grid[j, i] = new Coordinates(j, i, 0);
				}
			}
			origin = gridsize / 2;
		}

		/// <summary>
		/// x x x
		/// x m x
		/// x x x
		/// </summary>
		int FullGrid(int i, int j)
		{
			int total = 0;
			//left top
			total += grid[i - 1, j - 1].Value;
			//straight top
			total += grid[i, j - 1].Value;
			//right top
			total += grid[i + 1, j - 1].Value;
			//left
			total += grid[i - 1, j].Value;
			//right
			total += grid[i + 1, j].Value;
			//left bot
			total += grid[i - 1, j + 1].Value;
			//straight bot
			total += grid[i, j + 1].Value;
			//right bot
			total += grid[i + 1, j + 1].Value;
			return total;
		}
		/// <summary>
		/// m x x
		/// x x x
		/// x x x
		/// </summary>
		int LeftCornerX(int i, int j)
		{
			int total = 0;
			//right
			total += grid[i + 1, j].Value;
			//straight bot
			total += grid[i, j + 1].Value;
			//right bot
			total += grid[i + 1, j + 1].Value;
			return total;
		}

		/// <summary>
		/// x x x
		/// m x x
		/// x x x
		/// </summary>
		int LeftEdgeX(int i, int j)
		{
			int total = 0;
			//straight top
			total += grid[i, j - 1].Value;
			//right top
			total += grid[i + 1, j - 1].Value;
			//right
			total += grid[i + 1, j].Value;
			//straight bot
			total += grid[i, j + 1].Value;
			//right bot
			total += grid[i + 1, j + 1].Value;
			return total;
		}

		/// <summary>
		/// x x x
		/// x x x
		/// m x x
		/// </summary>
		int LeftGridCornerX(int i, int j)
		{
			int total = 0;
			//straight top
			total += grid[i, j - 1].Value;
			//right top
			total += grid[i + 1, j - 1].Value;
			//right
			total += grid[i + 1, j].Value;
			return total;
		}

		/// <summary>
		/// x x x
		/// x x x
		/// x m x
		/// </summary>
		int BotGridEdgeX(int i, int j)
		{
			int total = 0;
			//left top
			total += grid[i - 1, j - 1].Value;
			//straight top
			total += grid[i, j - 1].Value;
			//right top
			total += grid[i + 1, j - 1].Value;
			//left
			total += grid[i - 1, j].Value;
			//right
			total += grid[i + 1, j].Value;
			return total;
		}

		/// <summary>
		/// x x x
		/// x x x
		/// x x m
		/// </summary>
		int RightGridCornerX(int i, int j)
		{
			int total = 0;
			//left top
			total += grid[i - 1, j - 1].Value;
			//straight top
			total += grid[i, j - 1].Value;
			//left
			total += grid[i - 1, j].Value;
			return total;
		}

		/// <summary>
		/// x x x
		/// x x m
		/// x x x
		/// </summary>
		int RightEdgeX(int i, int j)
		{
			int total = 0;
			//left top
			total += grid[i - 1, j - 1].Value;
			//straight top
			total += grid[i, j - 1].Value;
			//left
			total += grid[i - 1, j].Value;
			//left bot
			total += grid[i - 1, j + 1].Value;
			//straight bot
			total += grid[i, j + 1].Value;
			return total;
		}

		/// <summary>
		/// x x m
		/// x x x
		/// x x x
		/// </summary>
		int RightCornerX(int i, int j)
		{
			int total = 0;
			//left
			total += grid[i - 1, j].Value;
			//left bot
			total += grid[i - 1, j + 1].Value;
			//straight bot
			total += grid[i, j + 1].Value;
			return total;
		}

		/// <summary>
		/// x m x
		/// x x x
		/// x x x
		/// </summary>
		int TopGridEdgeX(int i, int j)
		{
			int total = 0;
			//left
			total += grid[i - 1, j].Value;
			//right
			total += grid[i + 1, j].Value;
			//left bot
			total += grid[i - 1, j + 1].Value;
			//straight bot
			total += grid[i, j + 1].Value;
			//right bot
			total += grid[i + 1, j + 1].Value;
			return total;
		}

		int GetMatrixValues(int i, int j)
		{
			int gridcorner = gridsize - 1;

			if (i != 0 && j != 0 && i != gridcorner && j != gridcorner)
				return FullGrid(i, j);
			if (i == 0 && j == 0)
				return LeftCornerX(i, j);
			if (i == 0 && j != 0 && j != gridcorner)
				return LeftEdgeX(i, j);
			if (i == 0 && j == gridcorner)
				return LeftGridCornerX(i, j);
			if (i != 0 && i != gridcorner && j == gridcorner)
				return BotGridEdgeX(i, j);
			if (i == gridcorner && j == gridcorner)
				return RightGridCornerX(i, j);
			if (i == gridcorner && j != 0 && j != gridcorner)
				return RightEdgeX(i, j);
			if (i == gridcorner && j == 0)
				return RightCornerX(i, j);
			if (i != 0 && i != gridcorner && j == 0)
				return TopGridEdgeX(i, j);
			return 0;
		}

		public int CreateAdvancedGrid(int size, int valueLock)
		{
			SetupBasicGrid(size);

			grid[origin, origin] = new Coordinates(origin, origin, 1);
			grid[origin + 1, origin] = new Coordinates(origin + 1, origin, 1);
			grid[origin + 1, origin - 1] = new Coordinates(origin + 1, origin - 1, 2);
			int stepsInCurrentSpiral = 2;
			int stepcounter = 0;
			Direction current = Direction.left;
			Coordinates previous = grid[origin + 1, origin - 1];

			for (int i = 4; i <= size; i++)
			{
				switch (current)
				{
					case Direction.up:
						if (previous.Value > valueLock)
							return previous.Value;
						grid[previous.X, previous.Y - 1] = new Coordinates(previous.X, previous.Y - 1,
							GetMatrixValues(previous.X, previous.Y - 1));
						previous = grid[previous.X, previous.Y - 1];
						break;
					case Direction.down:
						if (previous.Value > valueLock)
							return previous.Value;
						grid[previous.X, previous.Y + 1] = new Coordinates(previous.X, previous.Y + 1,
						GetMatrixValues(previous.X, previous.Y + 1));
						previous = grid[previous.X, previous.Y + 1];
						break;
					case Direction.right:
						if (previous.Value > valueLock)
							return previous.Value;
						grid[previous.X + 1, previous.Y] = new Coordinates(previous.X + 1, previous.Y,
							GetMatrixValues(previous.X + 1, previous.Y));
						previous = grid[previous.X + 1, previous.Y];
						break;
					case Direction.left:
						if (previous.Value > valueLock)
							return previous.Value;
						grid[previous.X - 1, previous.Y] = new Coordinates(previous.X - 1, previous.Y,
							GetMatrixValues(previous.X - 1, previous.Y));
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
					else if (current == Direction.right && i != size)
					{
						i++;
						if (previous.Value > valueLock)
							return previous.Value;
						grid[previous.X + 1, previous.Y] = new Coordinates(previous.X + 1, previous.Y,
							GetMatrixValues(previous.X + 1, previous.Y));
						previous = grid[previous.X + 1, previous.Y];
						stepcounter++;
						current = Direction.up;
						stepsInCurrentSpiral += 2;
					}
				}
			}
			return 0; 
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
