using System;
using System.Collections;

//Solution for advent of code 2021: day 03

namespace Day03_Solution
{
    class Day03Runner
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

            ReportChecker reportChecker = new ReportChecker(input);
            reportChecker.CheckPowerConsumption();

            Console.WriteLine("Final power consumption: " + reportChecker.GetResult());
        }
    }

    class ReportChecker
    {
        private int result;
        private string[] report;

        public ReportChecker(string[] report)
        {
            this.report = report;
        }

        public void CheckPowerConsumption()
        {
            //arrays for determining gamma and epsilon values for each 
            //position in the length of the binary input string

            int[] zeroes = new int[report[0].Length];
            int[] ones = new int[report[0].Length];

            //binarystrings

            string gamma = "";
            string epsilon = "";

            //check every postion of all the binarystring in the report

            for (int i = 0; i < report.Length; i++)
            {
                for (int j = 0; j < report[i].Length; j++)
                {
                    if (report[i][j] == '0')
                        zeroes[j]++;
                    else
                        ones[j]++;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", zeroes));
            Console.WriteLine("[{0}]", string.Join(", ", ones));

            //find epsilon and gamma values.

            for (int i = 0; i < zeroes.Length; i++)
            {
                if (zeroes[i] < ones[i])
                {
                    gamma = gamma + "0";
                    epsilon = epsilon + "1";
                }
                else
                {
                    gamma = gamma + "1";
                    epsilon = epsilon + "0";
                }

            }
            // retrive the final score

            int gammaFinalScore = Convert.ToInt32(gamma, 2);
            int epsilonFinalScore = Convert.ToInt32(epsilon, 2);

            Console.WriteLine(String.Format(
                "Gamma: {0} ({2}) Epsilon: {1} ({3}) ",
                gamma,
                epsilon,
                gammaFinalScore,
                epsilonFinalScore)
            );

            int powerConsumption = gammaFinalScore * epsilonFinalScore;
            setResult(powerConsumption);

        }
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
