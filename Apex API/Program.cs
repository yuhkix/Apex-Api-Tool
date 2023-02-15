using System;
using Spectre.Console;
using Apex_API.Cmds;
using System.Diagnostics;

namespace Apex_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "APEX LEGENDS || API TOOL";

            if (Properties.Settings.Default.PlayerName == null && Properties.Settings.Default.Legend == null && Properties.Settings.Default.Platform == null && Properties.Settings.Default.PlayerUID == null)
            {
                Console.WriteLine("What's your EA Account Name?");
                Properties.Settings.Default.PlayerName = Console.ReadLine();

                Console.WriteLine("What's the Legend you use the most / want to inspect your stats from?");
                Properties.Settings.Default.Legend = Console.ReadLine();

                Console.WriteLine("What Platform do you play on? [PS4, X1, PC]");
                Properties.Settings.Default.Platform = Console.ReadLine();

                Console.WriteLine("What's your UID?");
                Properties.Settings.Default.PlayerUID = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("What would you like to display ?")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                .AddChoices(new[] {
                    "UserInfo", "Predator", 
                    "CraftingRotation", "StoreRotation", 
                    "News", "MapRotation", 
                    "ServerStatus", "Origin", 
                    "NameToUID", "Leaderboards",
                    "PlayerStats", "MatchHistory",
                }));

            switch (option)
            {
                case "UserInfo":
                    ReenterUserInfo();
                    break;
                case "Predator":
                    Predator.RPtoPred();
                    break;
                case "CraftingRotation":
                    CraftingRotation.CraftRotation();
                    break;
                case "StoreRotation":
                    StoreRotation.ShopRotation();
                    break;
                case "News":
                    News.Apexnews();
                    break;
                case "MapRotation":
                    MapRotation.MapRot();
                    break;
                case "ServerStatus":
                    ServerStatus.SStatus();
                    break;
                case "Origin":
                    Origin.OriginToUID();
                    break;
                case "NameToUID":
                    NameToUID.NameUID();
                    break;
                case "Leaderboards":
                    Leaderboards.Leaderboard();
                    break;
                case "PlayerStats":
                    PlayerStats.GetPlayerStats();
                    break;
                case "MatchHistory":
                    MatchHistory.UserMatchHistory();
                    break;
            }
            Console.ReadLine();
        }

        private static void ReenterUserInfo()
        {
            Console.WriteLine("What's your EA Account Name?");
            Properties.Settings.Default.PlayerName = Console.ReadLine();

            Console.WriteLine("What's the Legend you use the most / want to inspect your stats from?");
            Properties.Settings.Default.Legend = Console.ReadLine();

            Console.WriteLine("What Platform do you play on? [PS4, X1, PC]");
            Properties.Settings.Default.Platform = Console.ReadLine();

            Console.WriteLine("What's your UID?");
            Properties.Settings.Default.PlayerUID = Console.ReadLine();
            Properties.Settings.Default.Save();
            Process.GetCurrentProcess().Kill();
        }
    }
}
