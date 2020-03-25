using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebCrawler
{
    class Program
    {
        static string baseHttp = "http://";
        static string baseHttps = "https://";

        static void Main(string[] args)
        {
            try
            {
                int length = args.Length;
                switch (length)
                {
                    case 0:
                        Console.WriteLine("Please pass in the url of the site to be crawled.");
                        break;
                    case 1:
                        string url = args[0].ToString();
                        if (CheckUrl(url))
                        {
                            Console.WriteLine("Site is " + url);
                            Console.WriteLine();
                            string site = TestCrawl(url);
                            PrintCrawlList(site);
                        }
                        else
                            throw new Exception("the url must start with http:// or https://.");
                        break;
                    default:
                        break;
                }

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
        }

        async static private Task<String> Crawl(string url)
        {
            using (HttpClient proxy = new HttpClient())
            {
                string response = await proxy.GetStringAsync(url);
                return response;
            }

        }

        private static string TestCrawl(string url)
        {
            return Crawl(url).Result;
        }

        private static void PrintCrawlList(string site)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(site);

            foreach (HtmlNode link in htmlDoc.DocumentNode.SelectNodes("//a[@href]"))
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                Console.WriteLine(hrefValue);
            }
        }

        private static bool CheckUrl(string pUrl)
        {

            if ((pUrl.StartsWith(baseHttp)) || (pUrl.StartsWith(baseHttps)))
                return true;
            else
                return false;
        }
    }

}