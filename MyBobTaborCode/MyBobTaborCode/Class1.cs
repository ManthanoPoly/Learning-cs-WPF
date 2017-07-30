using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyBobTaborCode
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            //WebClient client = new WebClient();
            //return client.DownloadString(url);
            return GetWebpage(url);

        }

        public string ScrapeWebpage(string url, string filepath)
        {
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);
            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)  // private helpermethod - should be used every time you have code twice. 
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
