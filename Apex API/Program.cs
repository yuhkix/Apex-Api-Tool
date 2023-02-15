using System;
using Spectre.Console;
using Apex_API.Cmds;

namespace Apex_API
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "APEX LEGENDS || API TOOL";

            var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("What would you like to display ?")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                .AddChoices(new[] {
                    "Predator", "CraftingRotation",
                    "StoreRotation", "News",
                    "MapRotation", "ServerStatus",
                    "Origin", "NameToUID",
                    "Leaderboards",
                }));

            switch (option)
            {
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
                /*case "Origin":

                    break;
                case "NameToUID":

                    break;
                case "Leaderboards":
                    Leaderboards.Leaderboard();
                    break;*/
            }
            Console.ReadLine();
        }
    }
}
