using System;
using System.IO;
using System.Net;

namespace Apex_API.Cmds
{
    public class Predator
    {
        public static void RPtoPred()
        {
            Console.Clear();
            string APIKEY = "bb53fe83c4efc7e105a1d1876ee1d501";
            var url = $"https://api.mozambiquehe.re/predator?auth={APIKEY}";
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
