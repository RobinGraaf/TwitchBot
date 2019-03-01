using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot {
    public static class BotCommandHandler {

        static Random r = new Random();

        public static void PointsCommand(string speaker)
        {
            string userPoints =
                $"User {speaker} currently has {UserHandler.GetPointsFromUser(speaker).ToString()} points";
            ChatLink.SendTwitchMessage(userPoints);
        }

        public static void BetCommand(string speaker, int betAmount)
        {
            if (UserHandler.GetPointsFromUser(speaker) < betAmount)
            {
                ChatLink.SendTwitchMessage("Can't bet with points you don't have 4Head");
                return; 
            }
            ChatLink.SendTwitchMessage($"{speaker} bets with {betAmount}");

            var bet = r.Next(0, 100) + 1;
            if (bet > 50)
            {
                ChatLink.SendTwitchMessage($"{speaker} rolled a {bet} and wins! {betAmount} added to points. " +
                                           $"Current amount: {UserHandler.GetPointsFromUser(speaker) + betAmount}");
                UserHandler.AddPointsToUser(speaker, betAmount);
            }
            else
            {
                ChatLink.SendTwitchMessage($"{speaker} rolled a {bet} and loses! {betAmount} removed from points. " +
                                           $"Current amount: {UserHandler.GetPointsFromUser(speaker) - betAmount}");
                UserHandler.RemovePointsFromUser(speaker, betAmount);
            }

            
        }

    }
}
