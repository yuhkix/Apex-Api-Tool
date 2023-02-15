using System;
using System.IO;
using System.Net;

namespace Apex_API.Cmds
{
    public class NameToUID
    {
        public static void NameUID()
        {
            Console.Clear();
            var url = $"https://api.mozambiquehe.re/nametouid?auth={Properties.Settings.Default.APIkey}&player={Properties.Settings.Default.PlayerName}&platform={Properties.Settings.Default.Platform}";
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
