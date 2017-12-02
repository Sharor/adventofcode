using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
			ChecksumCalculator captcha = new ChecksumCalculator();
			Console.WriteLine("Captcha for the given puzzle is: " + captcha.TotalChecksum(new Puzzle().puzzle));
			Console.Read();
		}
	}
}
