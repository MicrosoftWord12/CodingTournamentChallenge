using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTournamentChallenge.Database.Select
{
    class SelectPlayerScore
    {
        public static int GetPlayerScore(int id)
        {
            string sql = $"select player_score from players where playerid={id}";
            return int.Parse(DBCommand.Command(sql).ExecuteScalar().ToString());
        }
    }
}
