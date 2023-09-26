using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace playwright_example
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class example_test: PageTest
    {
        [Test]
        public async Task smokeTest()
        {
            await Page.GotoAsync("https://localhost:44316/");
            await Expect(Page).ToHaveTitleAsync(new Regex("Home Page - My ASP.NET Application"));

            await Page.Locator("#navbar-about").ClickAsync();
            await Expect(Page).ToHaveTitleAsync(new Regex("About."));

            await Page.Locator("#navbar-contact").ClickAsync();
            await Expect(Page).ToHaveTitleAsync(new Regex("Contact."));

            await Page.Locator("#navbar-home").ClickAsync();
            await Expect(Page).ToHaveTitleAsync(new Regex("Home Page - My ASP.NET Application"));

        }
    }
}
