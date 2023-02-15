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
            string APIKEY = "bb53fe83c4efc7e105a1d1876ee1d501";
            string Legend = "Wraith";
            string Platform = "PC";
            var url = $"https://api.mozambiquehe.re/leaderboard?auth={APIKEY}&legend={Legend}&platform={Platform}";
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
