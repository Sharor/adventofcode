using System;
using Xunit;
using day1;

namespace day1test
{
	public class PuzzleTests
	{
		[Fact]
		public void PuzzleExample1()
		{
			string puzzle = "1122";
			CaptchaEvaluator captcha = new CaptchaEvaluator();
			int notAHuman = captcha.EvaluateCaptcha(puzzle);
			Assert.Equal(notAHuman, 3);
		}

		[Fact]
		public void PuzzleExample2()
		{
			string puzzle = "1111";
		}

		[Fact]
		public void PuzzleExample3()
		{
			string puzzle = "1234";
		}

		[Fact]
		public void PuzzleExample4()
		{
			string puzzle = "91212129";
		}
	}
}
