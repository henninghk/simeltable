using System;
using System.Collections.Generic;
using System.Text;

namespace simeltable
{
    class ScoreTable
    {
        public Dictionary<Team, ScoreTableRow> _rows;

        public ScoreTable()
        {
            _rows = new Dictionary<Team, ScoreTableRow>();
        }

        public void AddResult(MatchResult matchResult)
        {
            var homeRow = GetOrCreateScoreTableRow(matchResult._HomeTeam);
            homeRow.Add(matchResult, true);
            var awayRow = GetOrCreateScoreTableRow(matchResult._AwayTeam);
            awayRow.Add(matchResult, false);
        }

        public ScoreTableRow GetOrCreateScoreTableRow(Team team)
        {
            if (_rows.ContainsKey(team)) return _rows[team];
            var scoreTableRow = new ScoreTableRow(team._name);
            _rows.Add(team, scoreTableRow);
            return scoreTableRow;
        }

        public string GetDescription()
        {
            var txt = new StringBuilder();
            foreach (var row in _rows.Values)
            {
                txt.AppendLine($"{row._TeamName}\t| {row.GameCount}|\t| {row.ScoredGoals}|\t| {row.ConcededGoals}|");
            }

            return txt.ToString();
        }
    }
}