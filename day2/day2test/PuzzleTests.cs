using System;
using Xunit;
using day2; 

namespace day2test
{
    public class PuzzleTests
    {
        [Fact]
        public void PuzzleTest1()
        {
			string puzzle = "5	1	9	5";
			ChecksumCalculator checksum = new ChecksumCalculator();
			int value = checksum.RowChecksum(puzzle);
			Assert.Equal(value, 8); 
        }

		[Fact]
		public void PuzzleTest2()
		{
			string puzzle = "7	5	3";
			ChecksumCalculator checksum = new ChecksumCalculator();
			int value = checksum.RowChecksum(puzzle);
			Assert.Equal(value, 4);
		}

		[Fact]
		public void PuzzleTest3()
		{
			string puzzle = "2	4	6	8";
			ChecksumCalculator checksum = new ChecksumCalculator();
			int value = checksum.RowChecksum(puzzle);
			Assert.Equal(value, 6);
		}
		[Fact]
		public void PuzzleTest4()
		{
			string puzzle = @"5	1	9	5
7	5	3
2	4	6	8";
			ChecksumCalculator checksum = new ChecksumCalculator();
			int value = checksum.TotalChecksum(puzzle);
			Assert.Equal(value, 18);
		}
	}
}
