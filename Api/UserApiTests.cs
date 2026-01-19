using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightApiTest.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;


namespace PlaywrightApiTest.Api
{

    [TestFixture]
    public class UserApiTests : BaseApiTest
    {
        [TestFixture]
        public class UserApiTest : BaseApiTest
        {
            [Test]
            public async Task Create_User_Should_Return_201()
            {
                var payload = new
                {
                    name = "Agnès",
                    role = "Tester"
                };

                var response = await _request.PostAsync(
                    ApiEndpoints.CreateUser,
                    new APIRequestContextOptions
                    {
                        Data = payload
                    });

                Assert.That(response.Status, Is.EqualTo((int)HttpStatusCode.Created));
            }
        }
    }

}
