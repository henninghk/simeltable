using System;

namespace simeltable
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Team("Liverpool");
            var t2 = new Team("ManchesterU");
            var t3 = new Team("Arsenal FC");
            
            var scoreTable = new ScoreTable();
            
            var matchResult = new MatchResult(t1, t2, 2, 1);
            scoreTable.AddResult(matchResult);
            
            var matchResult2 = new MatchResult(t1, t3, 0, 1);
            scoreTable.AddResult(matchResult2);
            
            var matchResult3 = new MatchResult(t2, t3, 1, 1);
            scoreTable.AddResult(matchResult3);

            Console.WriteLine(scoreTable.GetDescription());

        }
    }
}