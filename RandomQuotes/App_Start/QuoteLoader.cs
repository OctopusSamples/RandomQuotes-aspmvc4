using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using RandomQuotes.Models;

namespace RandomQuotes
{
    public class QuoteLoader
    {
        public static void Initialize()
        {
            var quoteFilePath = HttpContext.Current.Server.MapPath("~/App_Data/quotes.txt");
            Quote.Quotes = File.Exists(quoteFilePath) ? File.ReadAllLines(quoteFilePath).Select(System.Net.WebUtility.HtmlDecode).ToList() : new List<string>();
            var authorFilePath = HttpContext.Current.Server.MapPath("~/App_Data/authors.txt");
            Quote.Authors = File.Exists(authorFilePath) ? File.ReadAllLines(authorFilePath).Select(System.Net.WebUtility.HtmlDecode).ToList() : new List<string>();
        }
    }
}