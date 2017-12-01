using System;
using Xunit;
using day1;

namespace day1test
{
	public class CaptchaEvaluatorTests
	{
		[Fact]
		public void TwoSameDigits()
		{
			string digits = "1122";
			CaptchaEvaluator captcha = new CaptchaEvaluator();
			int digitsResult = captcha.CheckConsecutiveDigits(digits);
			Assert.Equal(digitsResult, 3);
		}

		/// <summary>
		/// This is 3 since the test ignores the "edge case" of last digit linking to first digit
		/// </summary>
		[Fact]		
		public void MultiDigits()
		{
			string digits = "1111";
			CaptchaEvaluator captcha = new CaptchaEvaluator();
			int digitsResult = captcha.CheckConsecutiveDigits(digits);
			Assert.Equal(digitsResult, 3);
		}

		[Fact]
		public void MultiDigitsTwo()
		{
			string digits = "2222";
			CaptchaEvaluator captcha = new CaptchaEvaluator();
			int digitsResult = captcha.CheckConsecutiveDigits(digits);
			Assert.Equal(digitsResult, 6);
		}

		[Fact]
		public void EndConnects()
		{
			string digits = "11";
			CaptchaEvaluator captcha = new CaptchaEvaluator();
			int digitsResult = captcha.CheckEndMatchFirst(digits);
			Assert.Equal(digitsResult, 1);
		}

		[Fact]
		public void PuzzleExample4()
		{
			string puzzle = "91212129";
		}
	}
}
