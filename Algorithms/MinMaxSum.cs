using System;
namespace Algorithms
{
    public class MinMaxSum
    {
        public MinMaxSum()
        {
            
        }

        public void CalculateMinMaxSum(int[] InputArray)
        {
            long highest = InputArray[0];
			var highestIndex = 0;
            long lowest = InputArray[0];
			var lowestIndex = 0;
            var highestSet = false;
            var lowestSet = false;
			for (var i = 0; i < InputArray.Length; i++)
			{
                if (InputArray[i] > highest && highestSet)
				{
					highest = InputArray[i];
					highestIndex = i;
				}
                else if (!highestSet)
                {
                    highest = InputArray[i];
                    highestIndex = i;
					highestSet = true;
				}
                else if (InputArray[i] < lowest && lowestSet)
				{
					lowest = InputArray[i];
					lowestIndex = i;
				}
                else if (!lowestSet) 
                {
                    lowest = InputArray[i];
                    lowestIndex = i;
					lowestSet = true;
				}
			}

            var maxSum = 0L;
            var minSum = 0L;
            for (var j = 0; j < InputArray.Length; j++)
            {
                if (j == highestIndex){
                    maxSum += InputArray[j];
                }
                else if (j == lowestIndex)
                {
                    minSum += InputArray[j];
                }
                else{
                    minSum += InputArray[j];
                    maxSum += InputArray[j];
                }
            }

            Console.WriteLine($"{minSum} {maxSum} {highestIndex} {lowestIndex}");
        }

    }
}

//1, 2, 3, 4, 5