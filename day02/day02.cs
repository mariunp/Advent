using System;
using System.Collections;

//Solution for advent of code 2021: day 02

namespace Day02_Solution
{
    class Day02Runner
    {

        public static void Main(string[] args)
        {
            //main method for input from command line.

            string line;
            ArrayList allLines = new ArrayList();

            while ((line = Console.ReadLine()) != null)
            {
                allLines.Add(line);
            }

            string[] input = (string[])allLines.ToArray(typeof(string));
            SubmarineTrip christmasTrip = new SubmarineTrip(input);

            System.Console.WriteLine("Final Score:" + christmasTrip.getResult());
        }

    }

    class SubmarineTrip
    {
        //the 
        private int result;

        public SubmarineTrip(string[] controlSequence)
        {
            //Starts the dive with the controlSequence 
            dive(controlSequence);
        }

        public void dive(string[] controlSequence)
        {
            // values for the subs positioning:
            int depth = 0;
            int position = 0;

            for (int i = 0; i < controlSequence.Length; i++)
            {
                string[] lineContents = controlSequence[i].Split(' ');
                string move = lineContents[0].ToLower();
                int value = Int32.Parse(lineContents[1]);

                //manipulates the positioning of the sub based on the next move

                switch (move)
                {
                    case "up":
                        depth -= value;
                        Console.WriteLine(String.Format("going up, new positon: {0} depth: {1}", position, depth));
                        break;

                    case "down":
                        depth += value;
                        Console.WriteLine(String.Format("going down, new positon: {0} depth: {1}", position, depth));
                        break;

                    case "forward":
                        position += value;
                        Console.WriteLine(String.Format("going forward, new positon: {0} depth: {1}", position, depth));
                        break;

                    case "backward":
                        position -= value;
                        Console.WriteLine(String.Format("going backwards, new positon: {0} depth: {1}", position, depth));
                        break;
                }
            }
            //finds the resulting score based on the posistion of the sub.
            result = depth * position;
        }

        public int getResult()
        {
            return result;
        }


    }
}