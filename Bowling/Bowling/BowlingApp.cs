using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class BowlingApp
    {
        
         
        static void Main(string[] args)
        {
           
            int[] perfectStrike = new int[] {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
           
            int[] perfectSpare = new int[] {5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};

            int[] perfectMiss = new int[] { 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0 };

            int[] testCase4 = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 5, 5, 5 };

            int[] testCase5 = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 5, 4};

            int[] testCase6 = new int[] { 10, 5, 5, 4, 3, 6, 4, 5, 4, 3, 6, 4, 6, 2, 3, 4, 3, 7, 3, 2};


            int totalScore = AddBowlingScore(perfectStrike);

            int totalScore2 = AddBowlingScore(perfectSpare);

            int totalScore3 = AddBowlingScore(perfectMiss);

            int totalScore4 = AddBowlingScore(testCase4);

            int totalScore5 = AddBowlingScore(testCase5);

            int totalScore6 = AddBowlingScore(testCase6);

        }


        public static int AddBowlingScore(int[] rollSequence)
        {

            int n = 0;

            int[] arrayOfFrameScores = new int[21];

            while (n < rollSequence.Length) {

                try {
                    if (rollSequence[n] == 10)
                    {
                        arrayOfFrameScores[n] = rollSequence[n] + rollSequence[n + 1] + rollSequence[n + 2];
                    }
                    else if (rollSequence[n] != 10)
                    {
                        if (rollSequence[n] + rollSequence[n + 1] == 10)
                        {
                            arrayOfFrameScores[n] = rollSequence[n] + rollSequence[n + 1] + rollSequence[n + 2];
                        }
                        else
                        {
                            arrayOfFrameScores[n] = rollSequence[n] + rollSequence[n + 1];
                        }

                        n++;

                    }

                }


                catch (System.IndexOutOfRangeException e)
                {
                    System.Console.WriteLine(e.Message);
                }

                n++;
            }

            return arrayOfFrameScores.Sum();
        }


    }
}
