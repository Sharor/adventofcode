using System;
using Xunit;
using day3;

namespace day3test
{
    public class UnitTest1
    {
        [Fact]
        public void PuzzleTest1()
        {
			Spiral spiral = new Spiral(25);
			int steps = spiral.CalculateSteps(1);
			Assert.Equal(steps, 0); 
        }

		[Fact]
		public void PuzzleTest2()
		{
			Spiral spiral = new Spiral(25);
			int steps = spiral.CalculateSteps(12);
			Assert.Equal(steps, 3);
		}

		[Fact]
		public void PuzzleTest3()
		{
			Spiral spiral = new Spiral(25);
			int steps = spiral.CalculateSteps(23);
			Assert.Equal(steps, 2);
		}

		[Fact]
		public void PuzzleTest4()
		{
			Spiral spiral = new Spiral(1089);
			int steps = spiral.CalculateSteps(1024);
			Assert.Equal(steps, 31);
		}
	}
}
