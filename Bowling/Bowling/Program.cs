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

            // 12 strikes
            int[] perfectStrike = new int[] {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};

            // all spares
            int[] perfectSpare = new int[] {5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};

            // all misses
            int[] perfectMiss = new int[] { 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0 };

            int totalScore = AddBowlingScore(perfectStrike);


        }

     
        public static int AddBowlingScore(int[] rollSequence)
        {
            
            int n = 0;

            int[] arrayOfFrameScores = new int[400];

            while (rollSequence[n] == 10 && n <= rollSequence.Length - 3)
            {
                arrayOfFrameScores[n] = rollSequence[n] + rollSequence[n + 1] + rollSequence[n + 2];
                n++;
            }

            return arrayOfFrameScores.Sum();
        }

    }
}
