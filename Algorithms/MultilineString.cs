using System;
using System.Text;

namespace Algorithms
{
    public class MultilineString
    {

        private string _input;

        public MultilineString(string input)
        {
            _input = input;
        }


        public void PrintStringFiveWordsPerLine()
        {
            var stringArray = _input.Split(' ');
            StringBuilder line = new StringBuilder();
            var words = 0;

            foreach (var word in stringArray)
            {
                if (line.Length < 15 && words < 5)
                {
                    line.Append(word + " ");
                    words++;
                }
                else
                {
                    Console.WriteLine(line);
                    line = line.Clear();
                    line.Append(word + " ");
                    words = 0;
                }
            }
        }

    }
}
