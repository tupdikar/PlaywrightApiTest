https://playwright.dev/dotnet/docs/api-testing

Playwright can be used to get access to the REST API of your application.


Test your server API.
Prepare server side state before visiting the web application in a test.
Validate server side post-conditions after running some actions in the browser.

All of that could be achieved via APIRequestContext methods.

Microsoft.Playwright.MSTest package which creates a Playwright and Page instance for each test.

Setup Process

1. Open Visual Studio 2026 community version
2. Create NUnit playwright Test project >> Give path of C>>Sigma Projects >> PlaywrightApiTests
3. Goto Tools>> Command Line>> Developer Command Prompt
4. Run following command npm init playwright@latest
