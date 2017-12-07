using System;

namespace day5
{
    class Program
    {
        static void Main(string[] args)
        {
			Maze maze = new Maze();
			Console.WriteLine("Captcha for the given puzzle is: " + maze.Escape(new Puzzle().puzzle));
			Console.WriteLine("Captcha for the given puzzle is: " + maze.AdvancedEscape(new Puzzle().puzzle));
			Console.Read(); 
		}
    }
}
