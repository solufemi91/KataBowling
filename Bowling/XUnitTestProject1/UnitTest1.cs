using Bowling;
using FluentAssertions;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddBowlingsScoreForPerfectStrikeGame()
        {
            int[] perfectStrike = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            Program.AddBowlingScore(perfectStrike).Should().Be(300, "12 strikes have been scored");
        }

        [Fact]
        public void AddBowlingsScoreForPerfectSpareGame()
        {
            int[] perfectSpare = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

            Program.AddBowlingScore(perfectSpare).Should().Be(150, "21 rolls: 10 pairs of 5 and spare has been scored");
        }

        [Fact]
        public void AddBowlingsScoreForScoringNineForEachFrame()
        {
            int[] perfectMiss = new int[] { 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0, 9, 0 };

            Program.AddBowlingScore(perfectMiss).Should().Be(90, "20 rolls: 10 pairs of 9 and miss");
        }
    }
}
