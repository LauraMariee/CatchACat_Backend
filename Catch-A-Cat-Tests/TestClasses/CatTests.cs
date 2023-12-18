using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Net;


namespace Catch_A_Cat_Tests
{
    [TestClass]
    public class CatTests
    {

        public HttpClient CatchATestSetup() 
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7021/api/")
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        [TestMethod]
        public void TablesExist()
        {
            var client = CatchATestSetup();

            // List data response.
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "Cat/").Result;


            var actual = response.StatusCode;
            var expected = HttpStatusCode.OK;


            if (response.StatusCode != expected)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new AssertFailedException($"Expected status code {expected} but received {actual}");
            }


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCatByID()
        {
            var client = CatchATestSetup();
            var url = client.BaseAddress + "Cat/1";

            // List data response.
            HttpResponseMessage response = client.GetAsync(url).Result;


            var actual = response.StatusCode;
            var expected = HttpStatusCode.OK;

            if (response.StatusCode != expected)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new AssertFailedException($"Expected status code {expected} but received {actual}");
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
