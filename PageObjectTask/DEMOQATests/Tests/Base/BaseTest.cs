using DEMOQATests.Browser;
using NUnit.Framework;

namespace DEMOQATests.Tests.Base
{
    [TestFixture]
    public class BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Browser.GetDriver();
            BrowserUtil.SetMaximumWindowSize();
            Browser.Browser.GoToUrl();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Browser.StopDriverBrowser();
        }
    }
}