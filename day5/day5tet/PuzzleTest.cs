using day5;
using System;
using Xunit;

namespace day5tet
{
    public class PuzzleTest
    {
		string puzzle = @"0
3
0
1
-3";

		[Fact]
        public void PuzzleTest1()
        {			
			Maze maze = new Maze();
			int steps = maze.Escape(puzzle);
			Assert.Equal(steps, 5);
        }

		[Fact]
		public void PuzzleTest2()
		{
			Maze maze = new Maze();
			int steps = maze.AdvancedEscape(puzzle);
			Assert.Equal(steps, 10);
			Assert.Equal(maze.numbers, new int[] { 2, 3, 2, 3, -1 });
		}
	}
}
