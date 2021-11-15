using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTournamentChallenge.Database.Insert
{
    class InsertNewPlayer
    {
        public static void AddPlayerToTournament(string player_email, bool isSubscribed)
        {
            string sql = $"insert into players(player_email, player_score, subscribed) values(:player_email, :player_score, :subscribed)";
            Npgsql.NpgsqlCommand cmd = DBCommand.Command(sql);
            //cmd.Parameters.Add(player_email, NpgsqlTypes.NpgsqlDbType.Text);

            cmd.Parameters.AddWithValue("player_email", player_email);
            cmd.Parameters.AddWithValue("player_score", 0);
            cmd.Parameters.AddWithValue("subscribed", isSubscribed);
            cmd.ExecuteScalar();
            Console.WriteLine("Inserted new Player Success");
        }
    }
}
