using System;
using NUnit.Framework;
using RandomQuotes.Models;

namespace RandomQuotes.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            using (new FakeHttpContext.FakeHttpContext())
            {
                QuoteLoader.Initialize();
            }
        }

        [Test]
        public void GetQuote()
        {
            Assert.That(Quote.GetRandomQuote().QuoteText != "Something went wrong");
        }
    }
}