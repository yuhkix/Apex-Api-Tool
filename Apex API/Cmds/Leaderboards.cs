using System;
using System.IO;
using System.Net;

namespace Apex_API.Cmds
{
    public class Leaderboards
    {
        public static void Leaderboard()
        {
            Console.Clear();
            var url = $"https://api.mozambiquehe.re/leaderboard?auth={Properties.Settings.Default.APIkey}&legend={Properties.Settings.Default.Legend}&platform={Properties.Settings.Default.Platform}";
            var request = WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            Console.WriteLine(data);
        }
    }
}
