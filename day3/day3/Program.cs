using System;

namespace day3
{
    class Program
    {
		/// <summary>
		/// Can only compute uneven squared grid sizes (ie 33^2 but not 32^2)
		/// </summary>
		/// <param name="args"></param>
        static void Main(string[] args)
        {
			Spiral spiral = new Spiral(290521);
			spiral.CreateEmptyGrid(290521);
			Console.WriteLine("Captcha for the given puzzle is: " + spiral.CalculateSteps(289326));
			Console.WriteLine("Captcha for the advanced puzzle is: " + spiral.CreateAdvancedGrid(290521, 289326));			
			Console.Read(); 

        }
    }
}
