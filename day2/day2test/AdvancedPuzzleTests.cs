using System;
using Xunit;
using day2; 

namespace day2test
{
    public class AdvancedPuzzleTests
	{
        [Fact]
        public void PuzzleTest1()
        {
			string puzzle = "5	9	2	8";
			AdvancedChecksumCalculator checksum = new AdvancedChecksumCalculator();
			int value = checksum.RowChecksum(puzzle);
			Assert.Equal(value, 4); 
        }

		[Fact]
		public void PuzzleTest2()
		{
			string puzzle = "9	4	7	3";
			AdvancedChecksumCalculator checksum = new AdvancedChecksumCalculator();
			int value = checksum.RowChecksum(puzzle);
			Assert.Equal(value, 3);
		}

		[Fact]
		public void PuzzleTest3()
		{
			string puzzle = "3	8	6	5";
			AdvancedChecksumCalculator checksum = new AdvancedChecksumCalculator();
			int value = checksum.RowChecksum(puzzle);
			Assert.Equal(value, 2);
		}
		[Fact]
		public void PuzzleTest4()
		{
			string puzzle = @"5	9	2	8
9	4	7	3
3	8	6	5";
			AdvancedChecksumCalculator checksum = new AdvancedChecksumCalculator();
			int value = checksum.TotalChecksum(puzzle);
			Assert.Equal(value, 9);
		}
	}
}
