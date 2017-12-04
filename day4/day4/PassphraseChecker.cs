using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day4
{
	public class PassphraseChecker
	{
		public int CheckPassphrases(string passphrases)
		{
			int valid = 0;
			int invalid = 0;
			string[] splitLines = passphrases.Split('\n');
			foreach (string line in splitLines)
			{
				if (IsValid(line))
					valid++;
				else
					invalid++;
			}
			return valid;
		}

		public int AdvancedCheckPassphrases(string passphrases)
		{
			int valid = 0;
			string[] splitLines = passphrases.Split('\n');
			foreach (string line in splitLines)
			{
				if (AdvancedIsValid(line))
					valid++;
			}
			return valid;
		}

		public bool IsValid(string passphrase)
		{
			string[] passwords = passphrase.Split(' ');
			for (int i = 0; i < passwords.Length; i++)
			{
				for (int j = 0; j < passwords.Length; j++)
				{
					if (passwords[i] == passwords[j] && j != i)
						return false;
				}
			}
			return true;
		}

		public bool AdvancedIsValid(string passphrase)
		{
			string[] passwords = passphrase.Split(' ');
			for (int i = 0; i < passwords.Length; i++)
			{
				for (int j = 0; j < passwords.Length; j++)
				{
					if (j != i && AnagramChecker(passwords[i], passwords[j]))
					{
						return false;
					}
				}
			}
			return true;
		}

		public bool AnagramChecker(string word, string otherword)
		{
			string sortedWord = String.Concat(word.OrderBy(c => c));
			string sortedOtherWord = String.Concat(otherword.OrderBy(c => c));

			if (sortedWord == sortedOtherWord)
				return true;
			else
				return false;
		}
	}
}
