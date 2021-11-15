using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTournamentChallenge.Database.Select
{
    class SelectId
    {
        public static int GetId(string player_email)
        {
            string sql = $"select playerid from players where player_email={player_email}";
            return int.Parse(DBCommand.Command(sql).ExecuteScalar().ToString());
        }
    }
}
