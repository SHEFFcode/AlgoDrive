using System;
using System.Text;

namespace Algorithms
{
    public class LongestPallindrome
    {
        private string _input;
        public LongestPallindrome(string input)
        {
            _input = input;
        }

        public void longestPalindrome()
        {
            //abba => pass
            //asdfbb => pass
            //bab => pass
            //fabba => pass
            //abbaf => pass
            //fbab => pass
            //babf => pass
            //babad => pass
            //cbbd => pass
            //a => pass
            //bb => pass
            //abcba => pass
            //ccc => pass



            // a | x | x | x |  => true, a alone is a palinrome

            // a | b | x | x | => false, ab is not a palindrome

            // a | b | b | x | => false, abb is not a palindrome

            // a | b | b | a | => true, abba is a palindrome, we have reached the end of the string

            var boolContainer = new bool[_input.Length, _input.Length];

            for (var i = 0; i < _input.Length; i++)
            {
                boolContainer[i, i] = false;
            }


            for (var i = 0; i < _input.Length; i++)
            {

                StringBuilder currentString = new StringBuilder();
                currentString.Append(_input[i]);

                for (var j = i; j < _input.Length; j++)
                {


                    if (i == j)
                    {
                        boolContainer[i, j] = true;
                        continue;
                    }

					currentString.Append(_input[j]);


					if (currentString.Equals(ReverseString(currentString)))
                    {
						boolContainer[i, j] = true;
						continue;
                    }
                    else 
                    {
                        boolContainer[i, j] = false;
                    }


                }
            }

            PrintSolution(boolContainer,_input.Length, _input);

        }

        private StringBuilder ReverseString (StringBuilder forwardString)
        {
            StringBuilder reverseString = new StringBuilder();
            for (var i = forwardString.Length - 1; i > -1; i--)
            {
                reverseString.Append(forwardString[i]);
            }

            return reverseString;
        }

        private void PrintSolution(bool[,] boolContainer, int length, string input)
        {

            var absoluteStartIndex = 0;
            var absoluteEndIndex = 0;


            for (var i = 0; i < length; i++)
            {

				var currentStartIndex = 0;
				var currenEndIndex = 0;

                var startSet = false;
                var endSet = false;

                for (var j = 0; j < length; j++)
                {
                    if (boolContainer[i, j] == true && startSet == false && j >= currentStartIndex)
                    {
                        currentStartIndex = j;
                        startSet = true;
                    }
                    else if (boolContainer[i, j] == true && startSet == true && j > currenEndIndex)
                    {
                        currenEndIndex = j;
                        endSet = true;
                    }
                }

                if (currenEndIndex - currentStartIndex > absoluteEndIndex - absoluteStartIndex)
                {
                    if (startSet && endSet)
                    {
						absoluteStartIndex = currentStartIndex;
						absoluteEndIndex = currenEndIndex;
                    }
                }
            }

            Console.WriteLine($@"Longest possible pallindrome is {input.Substring(absoluteStartIndex, absoluteEndIndex + 1 - absoluteStartIndex)} and it is {absoluteEndIndex - absoluteStartIndex + 1} characters long!");

        }

    }
}
