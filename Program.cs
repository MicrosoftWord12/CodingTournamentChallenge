using System;
using CodingTournamentChallenge.Database.Insert;
using CodingTournamentChallenge.Database.Select;
using CodingTournamentChallenge.Questions;

namespace CodingTournamentChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            main.StartPoint();
        }

        public void StartPoint()
        {
            while (true)
            {
                bool optionQ = false;
                while (optionQ == false)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Add a player to the tournament?");
                    Console.WriteLine("2. Get a player's score from their tournament Id");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string email1 = AskForEmail.Email();
                            bool subscribed = AskForSubscribed.Subscribed();
                            InsertNewPlayer.AddPlayerToTournament(email1, subscribed);
                            optionQ = true;
                            break;

                        case 2:
                            string email2 = AskForEmail.Email();
                            int id = SelectId.GetId(email2);
                            Console.WriteLine($"The Players Score is... {SelectPlayerScore.GetPlayerScore(id)}");
                            optionQ = true;
                            break;

                        default:
                            Console.WriteLine("Input a valid Number according to what you want to do");
                            optionQ = false;
                            break;
                    }
                }
            }
        }
    }
}
