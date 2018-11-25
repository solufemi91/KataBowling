using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Program
    {
        
         
        static void Main(string[] args)
        {
            // create a groups of different arrays with possible roll sequences

            // 12 rolls
            // 12 strikes
            int[] perfectStrike = new int[] {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
            
            // 21 rolls
            // all spares
            int[] perfectSpare = new int[] {5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};

            // 20 rolls
            // all misses
            // note if the size of the array is 20 or more, stop the process on the 19th one i.e.[18]
            int[] perfectMiss = new int[] { 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0 };


            int totalScore = AddBowlingScore(perfectStrike);

            int totalScore2 = AddBowlingScore(perfectSpare);

            int totalScore3 = AddBowlingScore(perfectMiss);


        }



        // add perfect spares

        public static int AddBowlingScore(int[] rollSequence)
        {

            int n = 0;

            int[] arrayOfFrameScores = new int[400];

            // go through each value, add to total and check if its equal to 10,
            // if equal to 10, add next two numbers to the first number
            // total of this number becomes the first value of the frame array
            // if the first number is not equal to 10, go to next number add to total and check if its equal to 10
            // if so, go to the next number and add it to the first two numbers
            // total of this number becomes the first value of the frame array
            // if its not equal to 10
            // total of this number becomes the first value of the frame array
            // could catch exception when an attempt is made to index a non existent value in the array

            while (n < rollSequence.Length) {

                try {
                    if (rollSequence[n] == 10)
                    {
                        try
                        {
                            arrayOfFrameScores[n] = rollSequence[n] + rollSequence[n + 1] + rollSequence[n + 2];
                        }

                        catch (System.IndexOutOfRangeException e)
                        {
                            System.Console.WriteLine(e.Message);
                            
                        }


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
                        // this part of the code has move plus 2, instead of 1
                        n++;

                    }

                    //n++;
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
