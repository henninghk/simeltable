using System;

namespace simeltable
{
    class Program
    {
        static void Main(string[] args)
        {
            var team1 = new Team("Liverpool");
            var team2 = new Team("ManchesterU");
            var team3 = new Team("Arsenal FC");
            
            var scoreTable = new ScoreTable();
            
            var matchResult = new MatchResult(team1, team2, 2, 1);
            scoreTable.AddResult(matchResult);
            
            var matchResult2 = new MatchResult(team1, team3, 0, 1);
            scoreTable.AddResult(matchResult2);
            
            var matchResult3 = new MatchResult(team2, team3, 1, 1);
            scoreTable.AddResult(matchResult3);

            Console.WriteLine(scoreTable.GetDescription());

        }
    }
}