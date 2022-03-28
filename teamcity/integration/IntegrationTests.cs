using System;
using System.Net.Http;
using Xunit;

namespace integration
{
    public class IntegrationTests
    {
        [Fact]
        public async void CheckHomePage()
        {
            var homePage = "http://webapp/";
            Console.WriteLine($"testing {homePage}");

            var client = new HttpClient();
            using (var response = await client.GetAsync(homePage))
            {
                response.EnsureSuccessStatusCode();
            }
        }
    }
}