using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Begineers
{
    [Author("thankjo", "thankjo@gmail.com")]
    [TestFixture]
    class ExpenseReport
    {
        [TestCase,Order(1),Description("Expense Report Submissions")]
        public void SubmitExpensereport()
        {
            TestContext.Progress.WriteLine("executing SubmitExpensereport");
        }

        [TestCase, Order(2), Description("Expense Report approval")]
        public void ApproveExpensereport()
        {
            TestContext.Progress.WriteLine("executing ApproveExpensereport");
        }

        [TestCase, Order(3), Description("Expense Report rejection")]
        public void RejectExpensereport()
        {
            TestContext.Progress.WriteLine("executing RejectExpensereport");
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
