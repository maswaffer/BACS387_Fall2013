﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Bing;

namespace Ada.Lovelace2._0
{
    public class NewsService
    {
        public NewsService(string accountKey)
        {
            BingAccountKey = accountKey;
        }

        public string BingAccountKey { get; set; }

        public IEnumerable<NewsResult> SearchFor(string query)
        {

            // Create a Bing container.
            string rootUrl = "https://api.datamarket.azure.com/Bing/Search";
            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUrl));

            // The market to use.
            string market = "en-us";

            // Get news for science and technology.
            string newsCat = "rt_ScienceAndTechnology";

            // Configure bingContainer to use your credentials.
            bingContainer.Credentials = new NetworkCredential(BingAccountKey, BingAccountKey);

            // Build the query, limiting to 10 results.
            var newsQuery = bingContainer.News(query, null, market, null, null, null, null, newsCat, null);
            newsQuery = newsQuery.AddQueryOption("$top", 10);

            // Run the query and display the results.
            var newsResults = newsQuery.Execute();

           return newsResults;
        }
    }
}
