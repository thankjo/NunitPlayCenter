using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Begineers
{
    [SetUpFixture]
    class TestSetup
    {
        [OneTimeSetUp]
        public void StartBrowser()
        {
            TestContext.Progress.WriteLine("Starting up the browser");
        }

        [OneTimeTearDown]
        public void EndBrowser()
        {
            TestContext.Progress.WriteLine("Closing the browser");
        }
    }
}
