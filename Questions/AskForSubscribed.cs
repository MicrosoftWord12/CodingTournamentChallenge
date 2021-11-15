using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTournamentChallenge.Questions
{
    class AskForSubscribed
    {
        public static bool Subscribed()
        {
            bool test = true;
            while (test)
            {
                Console.WriteLine("Are you subscribed? true or false");
                string sub = Console.ReadLine();
                sub.ToLower();
                if (sub.Contains("true") || sub.Contains("false"))
                {
                    return bool.Parse(sub);
                }
                test = true;
            }
            return false;
        }
    }
}
