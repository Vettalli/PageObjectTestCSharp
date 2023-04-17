using DEMOQATests.Browser;
using DEMOQATests.Tests.Base;
using NUnit.Framework;

namespace DEMOQATests.Tests;

public class Tests : BaseTests
{
    [Test]
    public void Test()
    {
        BrowserUtil.ScrollPage();
        
        var i = 5;
        
        Assert.IsTrue(true);
    }
}