using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Begineers
{   [Author("thankjo","thankjo@gmail.com")]
    [NUnit.Framework.TestFixture]
    public class BeginnerStartup
    {
        [NUnit.Framework.TestCase,Description("This test is for checking the application status")]
        public void CheckingApplication()
        {

        }

        [SetUp]
        public void OpenDriver()
        {
            TestContext.Progress.WriteLine("open the driver with this testcase");
        }

        [TearDown]
        public void CloseDriver()
        {
            TestContext.Progress.WriteLine("Close the driver with this testcase");
        }
    }


}
