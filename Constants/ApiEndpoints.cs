using System;
using System.Collections.Generic;
using System.Text;

namespace PlaywrightApiTest.Utils
{
    public static class ApiEndpoints
    {
        public const string CreateUser = "/api/users";
        public const string GetUser = "/api/users/{id}";
        public const string DeleteUser = "/api/users/{id}";
    }
}
