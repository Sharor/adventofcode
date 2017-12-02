using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
			CaptchaEvaluator captcha = new CaptchaEvaluator();
			Console.WriteLine("Captcha for the given puzzle is: " + captcha.EvaluateCaptcha(new Puzzle().puzzle));
			AdvancedCaptchaEvaluator advancedCaptchaEvaluator = new AdvancedCaptchaEvaluator();
			Console.WriteLine("Captcha for the given puzzle is: " + advancedCaptchaEvaluator.EvaluateCaptcha(new Puzzle().puzzle));
			Console.Read();
        }
    }
}
