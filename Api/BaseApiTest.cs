using Microsoft.Playwright;
using NUnit.Framework;

namespace PlaywrightApiTest
{
    public class BaseApiTest
    {
        protected IAPIRequestContext Request;

        [OneTimeSetUp]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();

            Request = await playwright.APIRequest.NewContextAsync(new()
            {
                BaseURL = "https://reqres.in",
                ExtraHTTPHeaders = new Dictionary<string, string>
                {
                    { "Accept", "application/json" }
                }
            });
        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            await Request.DisposeAsync();
        }
    }
}
