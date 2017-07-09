using System;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms
{
    public class SteppingNumbers
    {
        public void SolveSteppingNumbers()
        {
            //Given Numbers
            var givenNumbers = new List<int>() { 10, 20 };
            var range = givenNumbers[1] - givenNumbers[0];
            var stepingNumbers = new List<int>();

            var numbersToTest = Enumerable.Range(givenNumbers[0], range + 1).ToList(); //n


            numbersToTest.ForEach(number => { //n
                if (CheckStepping(number))
                {
                    stepingNumbers.Add(number);
                }
            });

            if(stepingNumbers.Count > 0)
            {
                stepingNumbers.ForEach(stepingNumber => { //n
                    Console.WriteLine($"{stepingNumber}");
                });
            }
            else 
            {
                Console.WriteLine("There are no stepping numbers in this range.");
            }
        }

        private bool CheckStepping(int number)
        {
            var stringNumber = number.ToString();
            var digits = (from digit in stringNumber select (int)Char.GetNumericValue(digit)); //m

            for (int i = 0; i < digits.Count() - 1; i++)//m
            {
                if (Math.Abs(digits.ElementAt(i) - digits.ElementAt(i + 1)) == 1)
                {
                    continue;
                }
                else
                {
                    return false;    
                }
            }
            return true;
        }
    }
}