using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Web;
using Xunit;

namespace Test
{
    public class BodyStreamTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> waf;

        public BodyStreamTest(WebApplicationFactory<Startup> waf)
        {
            this.waf = waf;
        }
        [Fact]
        public async Task Test1()
        {
            using var client = waf.CreateClient();

            var response = await client.GetAsync("/");

            var responseContent = await response.Content.ReadAsStringAsync();

            Assert.Contains("Learn about", responseContent);
        }
    }
}
