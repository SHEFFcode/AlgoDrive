using System;
namespace Algorithms
{
    public class PallindromeChecker
    {

        private string _input;


        public PallindromeChecker(string input)
        {
            _input = input;
        }

        public void CheckForPallindrome()
        {
            var pointerOne = 0;
            var pointerTwo = 1;
            var midpoint = 0.0D;

            if (_input.Length % 2 != 0)
            {
				midpoint = Math.Round((double)_input.Length / 2, 0);
				pointerOne = (int)midpoint - 1;
				pointerTwo = (int)(midpoint + 1);

			}
            else 
            {
                midpoint = _input.Length / 2;
				pointerOne = (int)midpoint;
				pointerTwo = (int)midpoint - 1;
            }

            for (int i = 0; i < _input.Length / 2; i++)
            {
				if (_input[pointerOne] == _input[pointerTwo])
				{
                    continue;
				}
                else
                {
                    Console.WriteLine("This is not a pallindrome.");
                    return;
                }
            }


            Console.WriteLine("This is a pallindrome.");







            //abba => true
            //yuruy => true




        }
    }
}
