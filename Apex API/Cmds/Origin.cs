using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Apex_API.Cmds
{
    public class Origin
    {
        public static void OriginToUID()
        {
            Console.Clear();
            string APIKEY = "bb53fe83c4efc7e105a1d1876ee1d501";
            string PlayerName = "";
            var url = $"https://api.mozambiquehe.re/origin?auth={APIKEY}&player={PlayerName}";
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
