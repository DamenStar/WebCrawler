using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || args.Length > 1)
                Console.WriteLine("Please enter WebCrawler url");
            else
            {
                Console.WriteLine(args[0].ToString());
            }
            var url = args[0].ToString();
            string site = TestCrawl(url);
            PrintCrawlList(site);

            Console.ReadLine();
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
    }

}