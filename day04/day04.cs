using System;
using System.Collections;

//Solution for advent of code 2021: day XX
// get input at: https://adventofcode.com/2021/day/4/input

namespace Day04_Solution
{
    class Day04Runner
    {
        public static void Main(string[] args)
        {
            //main method for input from command line.

            string line;
            ArrayList bingoCards = new ArrayList();
            string[] rawBingoNumbers = Console.ReadLine().Split(",");
            int[] bingoNumbers = Array.ConvertAll(rawBingoNumbers, num => Int32.Parse(num));

            // dumping the empty line before the first bingo card
            Console.ReadLine();

            int cardRowCounter = 1;
            int[] card = new int[5];

            while ((line = Console.ReadLine()) != null)
            {
                if (cardRowCounter > 5)
                {
                    bingoCards.Add(card);
                    Array.Clear(card, 0, card.Length);
                    cardRowCounter = 1;
                    continue;
                }

                string[] contents = line.Split(' ');
                card[cardRowCounter - 1] = Array.ConvertAll(contents, num => Int32.Parse(num));
                cardRowCounter++;
            }

            SquidBingo squidGame = new SquidBingo(bingoNumbers, bingoCards);

        }
    }

    class SquidBingo
    {
        private int result = 0;

        private ArrayList bingoCards;
        private int[] bingoNumbers;

        public SquidBingo(int[] bingoNumbers, ArrayList bingoCards)
        {
            this.bingoCards = bingoCards;
            this.bingoNumbers = bingoNumbers;

        }

        public void play()
        {
            int[] calledNumbers = new int[bingoNumbers.Length];

            while (calledNumbers[calledNumbers.Length] != null)
            {
                foreach (int[][] card in bingoCards)
                {

                }
            }

        }

        private int[] drawNumbers()
        {

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