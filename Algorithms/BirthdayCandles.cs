using System;
namespace Algorithms
{
    public class BirthdayCandles
    {
        public BirthdayCandles()
        {
        }

		public int birthdayCakeCandles(int n, int[] ar)
		{

            var highestInt = 0;
            var highestIntCount = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] >= highestInt)
                {
                    highestInt = ar[i];
                }
            }

            for (int j = 0; j < ar.Length; j++)
            {

                if (ar[j] == highestInt)
				    highestIntCount++;

			}

            Console.WriteLine(highestIntCount);

            return -1;
		}
    }
}
