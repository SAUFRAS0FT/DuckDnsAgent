using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;

namespace DuckDnsAgent
{
    public class Agent
    {
        public bool UpdateDomain(string userToken, string domainName)
        {
            try {
                WebRequest req = WebRequest.Create("https://www.duckdns.org/update?domains=" + domainName + "&token=" + userToken);
                WebResponse rep = req.GetResponse();
                StreamReader sr = new StreamReader(rep.GetResponseStream());
                string repString = sr.ReadToEnd();
                sr.Close();
                if (repString == "OK")
                {
                    return true;
                } else
                {
                    return false;
                }

            } catch
            {
                return false;
            }
        }
    }
}
