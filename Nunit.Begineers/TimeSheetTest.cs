using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Begineers
{
    [Author("thankjo", "thankjo@gmail.com")]
    class TimeSheetTest
    {
        [TestCase,Order(1)]
        public void CreateTimeSheet()
        {
            TestContext.Progress.WriteLine("Executing CreateTimeSheet test cases");
        }

        [TestCase, Order(2)]
        public void SubmitTimeSheet()
        {
            TestContext.Progress.WriteLine("Executing SubmitTimeSheet test cases");                
        }

        [TestCase, Order(3)]       
        public void ApproveTimeSheet()
        {
            TestContext.Progress.WriteLine("Executing ApproveTimeSheet test cases");
        }

        [Author("anotherdev", "anotherdev@gmail.com")]
        [TestCase, Order(3)]
        public void RejectTimeSheet()
        {
            TestContext.Progress.WriteLine("Executing RejectTimeSheet test cases");
        }
    }
}
