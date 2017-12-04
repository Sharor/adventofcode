using System;
using Xunit;
using day4;

namespace day4test
{
	public class PuzzleTests
	{
		[Fact]
		public void PuzzleTest1()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.True(check.IsValid("aa bb cc dd ee"));
		}

		[Fact]
		public void PuzzleTest2()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.False(check.IsValid("aa bb cc dd aa"));
		}

		[Fact]
		public void PuzzleTest3()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.True(check.IsValid("aa bb cc dd aaa"));
		}

		[Fact]
		public void RealCaseTest1()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.False(check.IsValid("ites ites pbxzunl vljzh lqgerta pbxzunl"));
		}

		[Fact]
		public void RealCaseTest2()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.Equal(check.CheckPassphrases(new Puzzle().puzzle), 383);
		}

		[Fact]
		public void AdvancedTest1()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.True(check.AdvancedIsValid("abcde fghij"));
		}

		[Fact]
		public void AdvancedTest2()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.False(check.AdvancedIsValid("abcde xyz ecdab"));
		}

		[Fact]
		public void AdvancedTest3()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.True(check.AdvancedIsValid("a ab abc abd abf abj"));
		}

		[Fact]
		public void AdvancedTest4()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.True(check.AdvancedIsValid("iiii oiii ooii oooi oooo"));
		}

		[Fact]
		public void AdvancedTest5()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.False(check.AdvancedIsValid("oiii ioii iioi iiio"));
		}

		[Fact]
		public void AnagramCheckerTest1()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.True(check.AnagramChecker("aabb", "bbaa"));
		}

		[Fact]
		public void AnagramCheckerTest2()
		{
			PassphraseChecker check = new PassphraseChecker();
			Assert.False(check.AnagramChecker("aabb", "bbaaa"));
		}
	}
}