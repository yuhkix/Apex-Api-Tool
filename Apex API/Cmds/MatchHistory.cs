using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Apex_API.Cmds
{
    public class MatchHistory
    {
        public static void UserMatchHistory()
        {
            Console.Clear();
            var url = $"https://api.mozambiquehe.re/games?auth={Properties.Settings.Default.APIkey}&uid={Properties.Settings.Default.PlayerUID}";
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
