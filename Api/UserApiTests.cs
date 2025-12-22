using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Text.Json;

namespace PlaywrightApiTest.Api
{

    [TestFixture]
    public class UserApiTests : BaseApiTest
    {
        [Test]
        public async Task GetUsers_ShouldReturn200()
        {
            var response = await Request.GetAsync("/api/users?page=2");

            Assert.That(response.Status, Is.EqualTo(200));

            var responseBody = await response.TextAsync();
            Assert.That(responseBody, Does.Contain("email"));
        }
    }

}
