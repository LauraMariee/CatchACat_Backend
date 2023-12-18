using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Catch_A_Cat_Tests
{
    [TestClass]
    public class CatNameTests
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
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "CatName/").Result;

            var actual = response.StatusCode;
            var expected = System.Net.HttpStatusCode.OK;


            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
