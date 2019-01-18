using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Begineers
{
    [TestFixture]
    class LogInTest
    {
        [TestCase("mary","mary@1","user")]
        [TestCase("adminmary", "mary@1", "adminuser")]
        [TestCase("superusermary", "mary@1", "superuser")]
        public void ValidateCredentials(string username,string password,string role)
        {

        }

        
       
        [TestCase]
        public void PasswordRecovery()
        {
            Assert.Warn("The function is not in use");
        }
    }
}
