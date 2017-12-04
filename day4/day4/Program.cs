using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
			PassphraseChecker check = new PassphraseChecker();
			Console.WriteLine("Captcha for the given puzzle is: " + check.CheckPassphrases(new Puzzle().puzzle));
			Console.WriteLine("Captcha for the advanced puzzle is: " + check.AdvancedCheckPassphrases(new Puzzle().puzzle));
			Console.Read();
		}
    }
}
