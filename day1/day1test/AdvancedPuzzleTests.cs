using day1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace day1test
{
    public class AdvancedPuzzleTests
    {
		[Fact]
		public void PuzzleExample1()
		{
			string puzzle = "1212";
			AdvancedCaptchaEvaluator captcha = new AdvancedCaptchaEvaluator();
			int notAHuman = captcha.EvaluateCaptcha(puzzle);
			Assert.Equal(notAHuman, 6);
		}

		[Fact]
		public void PuzzleExample2()
		{
			string puzzle = "1221";
			AdvancedCaptchaEvaluator captcha = new AdvancedCaptchaEvaluator();
			int notAHuman = captcha.EvaluateCaptcha(puzzle);
			Assert.Equal(notAHuman, 0);
		}

		[Fact]
		public void PuzzleExample3()
		{
			string puzzle = "123425";
			AdvancedCaptchaEvaluator captcha = new AdvancedCaptchaEvaluator();
			int notAHuman = captcha.EvaluateCaptcha(puzzle);
			Assert.Equal(notAHuman, 4);
		}

		[Fact]
		public void PuzzleExample4()
		{
			string puzzle = "123123";
			AdvancedCaptchaEvaluator captcha = new AdvancedCaptchaEvaluator();
			int notAHuman = captcha.EvaluateCaptcha(puzzle);
			Assert.Equal(notAHuman, 12);
		}

		[Fact]
		public void PuzzleExample5()
		{
			string puzzle = "12131415";
			AdvancedCaptchaEvaluator captcha = new AdvancedCaptchaEvaluator();
			int notAHuman = captcha.EvaluateCaptcha(puzzle);
			Assert.Equal(notAHuman, 4);
		}
	}
}
