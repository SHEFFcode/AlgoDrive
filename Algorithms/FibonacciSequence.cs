using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class FibonacciSequence
    {
        private int _place;

        public FibonacciSequence(int place)
        {
            _place = place;
        }

        public void FindFibAtSpecifiedPlace()
        {
            var fibList = new int[] {0, 1};

            var fibAtPlace = Itereate(_place);
            Console.WriteLine(fibAtPlace);
        }

        private int Itereate(int cPlace)
        {

            return (cPlace == 1 || cPlace == 0) ? cPlace : Itereate(cPlace - 2) + Itereate(cPlace - 1);

        }
    }
}
