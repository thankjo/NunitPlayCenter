using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Begineers
{
    [TestFixture]
    class DataDrivenTests
    {

        static int[] ages = new int[] {11,12};

        [Test, TestCaseSource(nameof(ages))]
        public void ValidAgeGroups(int validage)
        {

        }
    }
}
