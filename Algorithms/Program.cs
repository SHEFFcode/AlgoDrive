using System;

namespace Algorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //SteppingNumbers stepNum = new SteppingNumbers();
            //stepNum.SolveSteppingNumbers();

            //var longestPalindrome = new LongestPallindrome("ccc");
            //longestPalindrome.longestPalindrome();

            //var stringPrinter = new MultilineString("Oh hey welcome to the vergecast my name is Joshua Topolsky and I am joined today by Paul Majic Miller and Nilay the Man Patel we are back again for the very first time and we are about to take you on a journey a journey through science and technology a journey u can scaresely afford to avoid or ignore a journey you will remember for the rest of your life scissor vodka cut through the night");
            //stringPrinter.PrintStringFiveWordsPerLine();

            //var fibBuilder = new FibonacciSequence(6);
            //fibBuilder.FindFibAtSpecifiedPlace();

            //var paramExtractor = new ExtractURLParams("https://wwww.google.com/images/?query=hello&user=jeremy&time=now&purpose=browse");
            //paramExtractor.ExtractUrlParams();


            //var palChecker = new PallindromeChecker("yuriy");
            //palChecker.CheckForPallindrome();

            //var minMaxSumCalculator = new MinMaxSum();
            //minMaxSumCalculator.CalculateMinMaxSum(new int[] {1, 2, 3, 4, 5 });


            var BirthdayCandles = new BirthdayCandles();
            BirthdayCandles.birthdayCakeCandles(1, new int[] {3, 2, 1, 3});

        }
    }
}
