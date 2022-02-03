using System;
using System.Collections;

//Solution for advent of code 2021: day 01

namespace Day01_Solution
{
    class Day01Runner
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

            int[] depths = (int[])allLines.ToArray(typeof(int));

            DepthChecker depthChecker = new DepthChecker(depths);
            Console.WriteLine("Result:" + depthChecker.getResult());

        }

    }

    class DepthChecker
    {
        private int result = 0;

        public DepthChecker(int[] depths)
        {
            int diveCounter = 0;

            for (int i = 0; i < (depths.Length); i++)
            {
                //since there is no previous measurment, skip the first index

                if (i == 0) continue;

                //Checks if the previous depth has increased since
                // the last measurment or not

                if (GoingDown(depths[i - 1], depths[i]))
                {
                    diveCounter++;
                    Console.WriteLine(String.Format("{0} (Going down!)", depths[i]));

                }
                else
                {
                    Console.WriteLine(String.Format("{0} (Going up!)", depths[i]));
                }
            }

            Console.WriteLine("Finished submarining");
            result = diveCounter;
        }

        private bool GoingDown(int baseDepth, int depth)
        {
            //checks if the new depth is deeper or equal to the previous 

            if (depth <= baseDepth)
                return false;
            else
                return true;
        }

        public int getResult()
        {
            //returns the final dive count 
            return result;
        }
    }

}