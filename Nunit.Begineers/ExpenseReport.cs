using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Begineers
{
    [Author("thankjo", "thankjo@gmail.com")]
    class ExpenseReport
    {
        [TestCase,Order(1),Description("Expense Report Submissions")]
        public void SubmitExpensereport()
        {

        }

        [TestCase, Order(2)]
        public void ApproveExpensereport()
        {

        }

        [TestCase, Order(3)]
        public void RejectExpensereport()
        {

        }
    }
}
