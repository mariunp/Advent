using System;
using System.Collections;

//Solution for advent of code 2021: day XX

namespace DayXX_Solution
{
    class DayXXRunner
    {

        public static void Main(string[] args)
        {
            //main method for input from command line.

            string line;
            ArrayList allLines = new ArrayList();

            while ((line = Console.ReadLine()) != null)
            {
                int numericLine = Int32.Parse(line);
                allLines.Add(numericLine);
            }

            int[] input = (int[])allLines.ToArray(typeof(int));
        }
    }

    class x
    {
        private int result = 0;

        public int GetResult()
        {
            return result;
        }

        private void setResult(int value)
        {
            result = value;
        }
    }
}